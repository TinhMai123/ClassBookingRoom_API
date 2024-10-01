using ClassBookingRoom_Repository.RequestModels.Department;
using ClassBookingRoom_Repository.ResponseModels.Department;
using ClassBookingRoom_Service.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace ClassBookingRoom_API.Controllers
{
    [Route("api/department")]
    [ApiController]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        [HttpGet]
        public async Task<ActionResult<List<DepartmentResponseModel>>> GetALl()
        {
            var departments = await _departmentService.GetAll();
            return Ok(departments);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<DepartmentResponseModel>> GetById([FromRoute]int id)
        {
            var department = await _departmentService.GetById(id);
            if (department == null)
            {
                return NotFound();
            }
            return Ok(department);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update([FromRoute]int id, [FromBody]UpdateDepartmentRequestModel dto)
        {
            var result = await _departmentService.Update(id, dto);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPost]
        public async Task<IActionResult> Create( [FromBody] CreateDepartmentRequestModel dto)
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
    }
}
