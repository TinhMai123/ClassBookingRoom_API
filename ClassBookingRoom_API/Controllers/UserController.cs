using ClassBookingRoom_BusinessObject.DTO.User;
using ClassBookingRoom_Service.IServices;
using Microsoft.AspNetCore.Mvc;

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
       
    }
}
