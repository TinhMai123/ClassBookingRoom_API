using ClassBookingRoom_BusinessObject.DTO.User;
using ClassBookingRoom_BusinessObject.Mappers;
using ClassBookingRoom_BusinessObject.Models;
using ClassBookingRoom_Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ClassBookingRoom_API.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<ActionResult<List<UserDTO>>> GetAllUsers()
        {
            var users = await _userService.GetAllUser();
            return Ok(users);
        }
        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<UserDetailDTO>> GetById([FromRoute] Guid id)
        {
            var users = await _userService.GetById(id);
            return Ok(users);
        }
        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateUserDTO dto)
        {
            var result = await _userService.UpdateUser(id, dto);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet("by-email")]
        public async Task<ActionResult<UserDetailDTO>> GetUserTypeByEmail(string email)
        {
            try
            {
                var user = await _userService.GetUserByEmailAsync(email);
                return user != null ? Ok(user) : NotFound("Can't find the email");
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
        [HttpPost]
        public async Task<IActionResult> AddNewUser(AddUserTestDTO add)
        {
            try
            {
                await _userService.AddUserAsync(add);
                return Ok("Add user succesfully");
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                var delete = await _userService.DeleteUserAsync(id);
                if (delete) return Ok("User Removed");
                else return NotFound("User Not Found");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO login)
        {
            try
            {
                var token = await _userService.Login(login);
                if (token != null) return Ok(token);
                else return NotFound("User Not Found");
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
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
                }
                else
                {
                    return Unauthorized();
                }
            }

            return Unauthorized();
        }
        [HttpGet("token")]
        public async Task<ActionResult<UserDTO>> CheckToken()
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
                return StatusCode(500);
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
