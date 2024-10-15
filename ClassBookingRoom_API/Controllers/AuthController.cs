using Azure.Core;
using ClassBookingRoom_Repository.RequestModels.Auth;
using ClassBookingRoom_Repository.ResponseModels.User;
using ClassBookingRoom_Service.IServices;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Net.Http.Headers;
using System.Security.Claims;

namespace ClassBookingRoom_API.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        public AuthController(IUserService userService, IConfiguration configuration)
        {
            _userService = userService;
            _configuration = configuration;
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
        public async Task<IActionResult> SendEmail(string body)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                var claims = identity.Claims;
                var email = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
                var role = claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;
                if (email != null && role != null)
                {
                    var message = new MimeMessage();
                    message.From.Add(MailboxAddress.Parse("noble.hackett@ethereal.email"));
                    message.To.Add(MailboxAddress.Parse("noble.hackett@ethereal.email"));
                    message.Subject = "Verify ";
                    message.Body = new TextPart(TextFormat.Html) { Text = body };

                    using var smtp = new SmtpClient();
                    await smtp.ConnectAsync("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
                    await smtp.AuthenticateAsync("noble.hackett@ethereal.email", "WMR3Jb9N17Uku69rVN");
                    await smtp.SendAsync(message);
                    await smtp.DisconnectAsync(true);

                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestModel login)
        {
            try
            {
                var token = await _userService.Login(login);
                if (token != null) return Ok(token);
                else return NotFound("User Not Found");
            } catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpPost("login-google")]
        public async Task<ActionResult<FirebaseToken>> LoginGoogle([FromBody] LoginGoogleRequest request)
        {
            try
            {
                var decodedToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(request.AccessToken);
                var jwtToken =await _userService.LoginGoogle(decodedToken, request.Role);
                return Ok(jwtToken);
            } catch (FirebaseAuthException ex)
            {
                return Unauthorized(new { error = ex.Message });
            }
        }

        [HttpGet("get-user-info")]
        public IActionResult GetUserInfo()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                var claims = identity.Claims;
                var email = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
                var role = claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;
                if (email != null && role != null)
                {
                    var user = _userService.GetUserByEmailAsync(email);
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
            var user = await _userService.GetUserByEmailAsync(email);
            if (user == null)
            {
                return BadRequest("email is in valid");
            }

            // If token is valid, return success response
            return Ok(user);
        }
        
    }
}
