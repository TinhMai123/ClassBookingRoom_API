using ClassBookingRoom_Repository.RequestModels.Activity;
using ClassBookingRoom_Repository.RequestModels.Department;
using ClassBookingRoom_Repository.ResponseModels.Activity;
using ClassBookingRoom_Repository.ResponseModels.Department;
using ClassBookingRoom_Service.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace ClassBookingRoom_API.Controllers
{
    [Route("api/departments")]
    [ApiController]
    public class DepartmentController : Controller
    {
        private readonly IActivityService _activityService;
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService, IActivityService activityService)
        {
            _departmentService = departmentService;
            _activityService = activityService;
        }
        [HttpGet]
        public async Task<ActionResult<List<DepartmentResponseModel>>> GetALl()
        {
            var departments = await _departmentService.GetAll();
            return Ok(departments);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<DepartmentResponseModel>> GetById([FromRoute] int id)
        {
            var department = await _departmentService.GetById(id);
            if (department == null)
            {
                return NotFound();
            }
            return Ok(department);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateDepartmentRequestModel dto)
        {
            var result = await _departmentService.Update(id, dto);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateDepartmentRequestModel dto)
        {
            var result = await _departmentService.Create(dto);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<DepartmentResponseModel>> Delete([FromRoute] int id)
        {
            var result = await _departmentService.Delete(id);
            if (result)
            {
                return Ok();
            }
            return NotFound();
        }
        // ACTIVITIES

        [HttpGet("activites/{id:int}")]
        public async Task<ActionResult<ActivityResponseModel>> GetActivityById([FromRoute] int id)
        {
            var activity = await _activityService.GetById(id);
            if (activity == null) { return NotFound(); }
            return Ok(activity);
        }

        [HttpGet("activities")]
        public async Task<ActionResult<List<ActivityResponseModel>>> GetAllActivities()
        {
            var list = await _activityService.GetAll();
            return Ok(list);
        }

        [HttpPost("activities")]
        public async Task<ActionResult> CreateActivity(CreateActivityRequestModel add)
        {
            var result = await _activityService.CreateAsync(add);
            if (result)
            {
                return Ok();
            } else
            {
                return BadRequest();
            }

        }

        [HttpPut("activities/{id:int}")]
        public async Task<ActionResult> UpdateActivity([FromRoute] int id, [FromBody] UpdateActivityRequestModel update)
        {
            var result = await _activityService.UpdateAsync(id, update);

            if (result)
            {
                return Ok();
            } else
            {
                return BadRequest();
            }
        }

        [HttpDelete("activities/{id:int}")]
        public async Task<ActionResult> DeleteActivity([FromRoute] int id)
        {
            var result = await _activityService.DeleteAsync(id);
            if (result)
            {
                return Ok(result);
            } else
            {
                return BadRequest();
            }
        }
    }
}
