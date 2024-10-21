using ClassBookingRoom_Repository.RequestModels.Auth;
using ClassBookingRoom_Repository.ResponseModels.User;
using ClassBookingRoom_Service.IServices;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using Newtonsoft.Json;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ClassBookingRoom_API.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        /*        private readonly IRedisService _redisService;*/
        public AuthController(IUserService userService, IConfiguration configuration/*, IRedisService redisService*/)
        {
            _userService = userService;
            _configuration = configuration;
            /* _redisService = redisService;*/
            if (FirebaseApp.DefaultInstance == null)
            {
                var googleCredentialSection = _configuration.GetSection("GoogleCredential").Get<Dictionary<string, string>>();
                var credential = GoogleCredential.FromJson(JsonConvert.SerializeObject(googleCredentialSection));
                FirebaseApp.Create(new AppOptions()
                {
                    Credential = credential,
                });
            }
        }
        [HttpPost("send-email")]
        public async Task<IActionResult> SendEmail()
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;

                if (identity != null)
                {

                    var claims = identity.Claims;
                    var email = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
                    var role = claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;
                    if (email != null && role != null)
                    {
                        Random random = new Random();
                        string verificationCode = random.Next(100000, 999999).ToString();
                        var message = new MimeMessage();
                        message.From.Add(MailboxAddress.Parse(_configuration["SmtpAccount:email"]));
                        message.To.Add(MailboxAddress.Parse(email));
                        message.Subject = "Verify Your Class Booking Room Account";
                        message.Body = new TextPart(TextFormat.Html)
                        {
                            Text =
                                 $@"
                                <html>
                                <body style='font-family: Arial, sans-serif;'>
                                    <h2>Verify Your Class Booking Room Account</h2>
                                    <p>Hello,</p>
                                    <p>Thank you for registering your account with us. To complete your registration, 
                                    please verify your email address using the verification code below:</p>
                                    <div style='margin: 20px 0; font-size: 18px; font-weight: bold;'>
                                        <span style='background-color: #f2f2f2; padding: 10px; border-radius: 5px;'>
                                             {verificationCode}
                                        </span>
                                    </div>
                                    <p>Enter this code on the verification page to complete your account setup.</p>
                                    <p>If you did not request this verification, please ignore this email.</p>
                                    <br/>
                                    <p>Best regards,<br/>Class Booking Room Team</p>
                                </body>
                                </html>
                            "
                        };
                        /* _redisService.SetVerificationCode(email, verificationCode, TimeSpan.FromMinutes(5));*/
                        using var smtp = new SmtpClient();
                        await smtp.ConnectAsync("smtp.gmail.com", 465, true);
                        await smtp.AuthenticateAsync(_configuration["SmtpAccount:email"], _configuration["SmtpAccount:password"]);
                        await smtp.SendAsync(message);
                        await smtp.DisconnectAsync(true);
                        return Ok();
                    }
                }
                return BadRequest();
            } catch (Exception ex) { return StatusCode(500, ex.Message); }
        }
        [HttpPost("{userId:Guid}/send-verification-email")]
        public async Task<IActionResult> SendVerificationEmail([FromRoute] Guid userId)
        {

            try
            {
                var user = await _userService.GetById(userId);
                if (user == null)
                {
                    return BadRequest("User not found.");
                }
                if (user.IsVerify)
                {
                    return BadRequest("User is already verified.");
                }
                Random random = new Random();
                var newVerificationToken = random.Next(100000, 999999).ToString();
                var updateTokenResult = await _userService.UpdateVerifyToken(userId, newVerificationToken);
                if (!updateTokenResult)
                {
                    return StatusCode(500, "Failed to update verification token");
                }
                var message = new MimeMessage();
                message.From.Add(MailboxAddress.Parse(_configuration["SmtpAccount:email"]));
                message.To.Add(MailboxAddress.Parse(user.Email));
                message.Subject = "Verify Your Class Booking Room Account";
                message.Body = new TextPart(TextFormat.Html)
                {
                    Text =
                         $@"
                                <html>
                                <body style='font-family: Arial, sans-serif;'>
                                    <h2>Verify Your Class Booking Room Account</h2>
                                    <p>Hello,</p>
                                    <p>Thank you for registering your account with us. To complete your registration, 
                                    please verify your email address using the verification code below:</p>
                                    <div style='margin: 20px 0; font-size: 18px; font-weight: bold;'>
                                        <span style='background-color: #f2f2f2; padding: 10px; border-radius: 5px;'>
                                             {newVerificationToken}
                                        </span>
                                    </div>
                                    <p>Enter this code on the verification page to complete your account setup.</p>
                                    <p>If you did not request this verification, please ignore this email.</p>
                                    <br/>
                                    <p>Best regards,<br/>Class Booking Room Team</p>
                                </body>
                                </html>
                            "
                };
                /* _redisService.SetVerificationCode(email, verificationCode, TimeSpan.FromMinutes(5));*/
                using var smtp = new SmtpClient();
                await smtp.ConnectAsync("smtp.gmail.com", 465, true);
                await smtp.AuthenticateAsync(_configuration["SmtpAccount:email"], _configuration["SmtpAccount:password"]);
                await smtp.SendAsync(message);
                await smtp.DisconnectAsync(true);
                return Ok("Verification email sent successfully.");
            } catch (Exception ex) { return StatusCode(500, ex.Message); }
        }

        [HttpPost("{userId:Guid}/verify")]
        public async Task<IActionResult> VerifyUser([FromRoute] Guid userId, [FromBody] string verifyToken)
        {
            try
            {
                bool result = await _userService.VerifyUser(userId, verifyToken);
                if (result)
                {
                    return Ok("User is verified successfully");
                } else
                {
                    return BadRequest("Incorrect verification code provided");
                }

            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestModel login)
        {
            try
            {
                var token = await _userService.Login(login);
                if (token != null) return Ok(token);
                else return NotFound("User Not Found");
            } catch (Exception ex) { return StatusCode(500, ex.Message); }
        }

        [HttpPost("login-google")]
        public async Task<ActionResult<FirebaseToken>> LoginGoogle([FromBody] LoginGoogleRequest request)
        {
            try
            {
                var decodedToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(request.AccessToken);
                var jwtToken = await _userService.LoginGoogle(decodedToken, request.Role);
                return Ok(jwtToken);
            } catch (FirebaseAuthException ex)
            {
                return Unauthorized(new { error = ex.Message });
            }
        }

        [HttpGet("get-user-info")]
        public async Task<IActionResult> GetUserInfo()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                var claims = identity.Claims;
                var email = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
                var role = claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;
                if (email != null && role != null)
                {
                    var user = await _userService.GetUserDetailByEmailAsync(email);
                    return Ok(user);
                } else
                {
                    return Unauthorized();
                }
            }

            return Unauthorized();
        }
        [HttpGet("token")]
        public async Task<ActionResult<UserResponseModel>> CheckToken()
        {
            Request.Headers.TryGetValue("Authorization", out var token);
            token = token.ToString().Split()[1];
            // Here goes your token validation logic
            if (string.IsNullOrWhiteSpace(token))
            {
                return BadRequest("Authorization header is missing or invalid.");
            }
            // Decode the JWT token
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);

            // Check if the token is expired
            if (jwtToken.ValidTo < DateTime.UtcNow)
            {
                return BadRequest("Token has expired.");
            }

            string? email = jwtToken.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress")?.Value;
            if (email is null)
            {
                return StatusCode(401);
            }
            var user = await _userService.GetUserDetailByEmailAsync(email);
            if (user == null)
            {
                return BadRequest("email is in valid");
            }

            // If token is valid, return success response
            return Ok(user);
        }

    }
}
