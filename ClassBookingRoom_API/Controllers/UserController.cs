using ClassBookingRoom_Repository.RequestModels.User;
using ClassBookingRoom_Repository.ResponseModels.User;
using ClassBookingRoom_Service.IServices;
using Microsoft.AspNetCore.Mvc;

namespace ClassBookingRoom_API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<UserDetailResponseModel>> GetById([FromRoute] Guid id)
        {
            var users = await _userService.GetById(id);
            return Ok(users);
        }
        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateUserRequestModel dto)
        {
            var result = await _userService.UpdateUser(id, dto);
            if (result)
            {
                return Ok();
            } else
            {
                return BadRequest();
            }
        }
        [HttpGet("by-email")]
        public async Task<ActionResult<UserDetailResponseModel>> GetUserTypeByEmail(string email)
        {
            try
            {
                var user = await _userService.GetUserDetailByEmailAsync(email);
                return user != null ? Ok(user) : NotFound("Can't find the email");
            } catch (Exception ex) { return BadRequest(ex.Message); }
        }
        [HttpPost]
        public async Task<IActionResult> AddNewUser(CreateUserRequestModel dto)
        {
            try
            {
                await _userService.AddUserAsync(dto);
                return Ok("Add user succesfully");
            } catch (Exception ex) { return BadRequest(ex.Message); }
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            try
            {
                var delete = await _userService.DeleteUserAsync(id);
                if (delete) return Ok("User Removed");
                else return NotFound("User Not Found");
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public async Task<ActionResult<List<UserDetailResponseModel>>> SearchUser([FromQuery]SearchUserQuery query)
        {
            var (users, totalCount) = await _userService.SearchUser(query);
            var totalPages = (int)Math.Ceiling((double)totalCount / query.PageSize);
            Response.Headers.Append("X-Total-Count", totalCount.ToString());
            Response.Headers.Append("X-Current-Page", query.PageNumber.ToString());
            Response.Headers.Append("X-Total-Pages", totalPages.ToString());
            return Ok(users);
        }
        [HttpPut("{id}/department-cohort")]
        public async Task<IActionResult> UpdateDepartmentAndCohort([FromRoute] Guid id, [FromBody] UpdateUserShortRequestModel dto)
        {
            try {
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
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
        [HttpPut("{id}/status")]
        public async Task<IActionResult> UpdateStatus([FromRoute] Guid id, string Status)
        {
            try
            {
                var result = await _userService.UpdateUser(id, Status);
                if (result)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
