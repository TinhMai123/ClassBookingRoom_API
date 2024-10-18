using ClassBookingRoom_Repository.Models;
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
        private readonly IFaceDescriptorService _faceDescriptorService;
        public UserController(IUserService userService, IFaceDescriptorService faceDescriptorService)
        {
            _userService = userService;
            _faceDescriptorService = faceDescriptorService;
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
                var user = await _userService.GetUserByEmailAsync(email);
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

        // FACE DESCRIPTOR
        [HttpGet("face")]
        public async Task<ActionResult<List<FaceDescriptor>>> GetAll()
        {
            var faceDescriptors = await _faceDescriptorService.GetAll();
            return Ok(faceDescriptors);
        }

        [HttpGet("face/{id}")]
        public async Task<ActionResult<FaceDescriptor>> GetById(int id)
        {
            var faceDescriptor = await _faceDescriptorService.GetById(id);
            if (faceDescriptor == null)
            {
                return NotFound();
            }
            return Ok(faceDescriptor);
        }

        [HttpPost("face")]
        public async Task<ActionResult> Add([FromBody] FaceDescriptor faceDescriptor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _faceDescriptorService.AddAsync(faceDescriptor);
            return CreatedAtAction(nameof(GetById), new { id = faceDescriptor.Id }, faceDescriptor);
        }

        [HttpPut("face/{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] FaceDescriptor faceDescriptor)
        {
            if (id != faceDescriptor.Id)
            {
                return BadRequest("ID mismatch");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingFaceDescriptor = await _faceDescriptorService.GetById(id);
            if (existingFaceDescriptor == null)
            {
                return NotFound();
            }

            await _faceDescriptorService.UpdateAsync(faceDescriptor);
            return NoContent();
        }

        [HttpDelete("face/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var faceDescriptor = await _faceDescriptorService.GetById(id);
            if (faceDescriptor == null)
            {
                return NotFound();
            }

            await _faceDescriptorService.DeleteAsync(id);
            return NoContent();
        }
        [HttpPut("{id:Guid}/fill-info")]
        public async Task<IActionResult> UpdateFillInfo([FromRoute] Guid id, [FromBody] FillInfoRequestModel dto)
        {
            var result = await _userService.FillInfo(id, dto);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut("{id:Guid}/status")]
        public async Task<IActionResult> UpdateStatus([FromRoute] Guid id, [FromBody] StatusRequestModel dto)
        {
            var result = await _userService.Status(id, dto);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
