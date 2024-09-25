using ClassBookingRoom_BusinessObject.DTO.User;
using ClassBookingRoom_BusinessObject.Models;
using ClassBookingRoom_Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ClassBookingRoom_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("user-type-by-email")]
        public async Task<IActionResult> GetUserTypeByEmail(string email) {
            try
            {
                var user = await _userService.GetUserTypeByEmailAsync(email);
                return user != null ? Ok(user) : NotFound("Can't find the email");   
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
        [AllowAnonymous]
        [HttpPut("Add-user")]
        public async Task<IActionResult> AddNewUser(AddUserTestDTO add)
        {
            try
            {
                await _userService.AddUserAsync(add);
                return Ok("Add user succesfully");
            }
            catch(Exception ex) { return BadRequest(ex.Message); }
        }
        [HttpGet("user-by-email")]
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            try
            {
                var user = await _userService.GetUserByEmailAsync(email);
                return user != null ? Ok(user) : NotFound("Can't find the email");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("Delete-user")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                var delete = await _userService.DeleteUserAsync(id);
                if (delete) return Ok("User Removed");
                else return NotFound("User Not Found");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDTO login)
        {
            try
            {
                var token = await _userService.Login(login);
                if (token != null) return Ok(token);
                else return NotFound("User Not Found");
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
        [HttpGet("GetUserInfo")]
        public IActionResult GetUserInfo()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                var claims = identity.Claims;
                var email = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
                var role = claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;

                return Ok(new
                {
                    Email = email,
                    Role = role
                });
            }

            return Unauthorized();
        }
    }
}
