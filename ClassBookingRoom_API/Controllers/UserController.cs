using ClassBookingRoom_BusinessObject.DTO;
using ClassBookingRoom_BusinessObject.Models;
using ClassBookingRoom_Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassBookingRoom_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("user-by-email")]
        public async Task<IActionResult> GetUserByEmail(string email) {
            try
            {
                var user = await _userService.GetUserByEmailAsync(email);
                return user != null ? Ok(user) : NotFound("Can't find the email");   
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
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

    }
}
