using ClassBookingRoom_Repository.RequestModels.FaceDescriptor;
using ClassBookingRoom_Repository.RequestModels.User;
using ClassBookingRoom_Repository.ResponseModels.FaceDescriptor;
using ClassBookingRoom_Repository.ResponseModels.Report;
using ClassBookingRoom_Repository.ResponseModels.User;
using ClassBookingRoom_Service.IServices;
using ClassBookingRoom_Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClassBookingRoom_API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IReportService _reportService;
        private readonly IFaceDescriptorService _faceDescriptorService;
        public UserController(IUserService userService, IFaceDescriptorService faceDescriptorService, IReportService reportService)
        {
            _userService = userService;
            _faceDescriptorService = faceDescriptorService;
            _reportService = reportService;
        }
        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<UserResponseModel>> GetById([FromRoute] Guid id)
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
        public async Task<ActionResult<UserResponseModel>> GetUserTypeByEmail(string email)
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
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteUser([FromRoute]Guid id)
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
        public async Task<ActionResult<List<UserResponseModel>>> SearchUser([FromQuery] SearchUserQuery query)
        {
            var (users, totalCount) = await _userService.SearchUser(query);
            var totalPages = (int)Math.Ceiling((double)totalCount / query.PageSize);
            Response.Headers.Append("X-Total-Count", totalCount.ToString());
            Response.Headers.Append("X-Current-Page", query.PageNumber.ToString());
            Response.Headers.Append("X-Total-Pages", totalPages.ToString());
            return Ok(users);
        }
        [HttpPut("{id:Guid}/department-cohort")]
        public async Task<IActionResult> UpdateDepartmentAndCohort([FromRoute] Guid id, [FromBody] UpdateUserShortRequestModel dto)
        {
            try
            {
                var result = await _userService.UpdateUser(id, dto);
                if (result)
                {
                    return Ok();
                } else
                {
                    return BadRequest();
                }
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id:Guid}/status")]
        public async Task<ActionResult> DenyBooking([FromRoute] Guid id, [FromBody] UpdateUserStatusRequest request)
        {
            try
            {
                var result = await _userService.UpdateUserStatus(id, request);
                if (result)
                {
                    return Ok("User deativated successfully");
                }
                return BadRequest();
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("{id:Guid}/reports")]
        public async Task<ActionResult<IEnumerable<ReportResponseModel>>> GetReportsByUserId([FromRoute] Guid id)
        {
            try
            {
                var result = await _reportService.GetReportsByUserId(id);
                return Ok(result);
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        // FACE DESCRIPTOR
        [HttpGet("face")]
        public async Task<ActionResult<List<FaceDescriptorResponseModel>>> GetAll()
        {
            var faceDescriptors = await _faceDescriptorService.GetAll();
            return Ok(faceDescriptors);
        }

        [HttpGet("face/{id:int}")]
        public async Task<ActionResult<FaceDescriptorResponseModel>> GetById(int id)
        {
            var faceDescriptor = await _faceDescriptorService.GetById(id);
            if (faceDescriptor == null)
            {
                return NotFound();
            }
            return Ok(faceDescriptor);
        }

        [HttpGet("{userId:Guid}/face")]
        public async Task<ActionResult<FaceDescriptorResponseModel>> GetByUserId(Guid userId)
        {
            var faceDescriptor = await _faceDescriptorService.GetByUserId(userId);
            if (faceDescriptor == null)
            {
                return NotFound();
            }
            return Ok(faceDescriptor);
        }

        [HttpPost("face")]
        public async Task<ActionResult> Add([FromQuery] CreateFaceDescriptorRequestModel faceDescriptor)
        {
            try
            {
                await _faceDescriptorService.AddAsync(faceDescriptor);
                return Ok("Added successfully");
            } catch (Exception ex) { return BadRequest(ex.Message); }

        }

        [HttpPut("face/{id:int}")]
        public async Task<ActionResult> Update(int id, [FromQuery] UpdateFaceDescriptorRequestModel faceDescriptor)
        {
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

        [HttpDelete("face/{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var faceDescriptor = await _faceDescriptorService.GetById(id);
                if (faceDescriptor == null)
                {
                    return NotFound();
                }

                await _faceDescriptorService.DeleteAsync(id);
                return Ok("Delete Successfully");
            } catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
