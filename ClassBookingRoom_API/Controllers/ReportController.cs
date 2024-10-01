using ClassBookingRoom_Repository.RequestModels.Report;
using ClassBookingRoom_Repository.ResponseModels.Report;
using ClassBookingRoom_Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassBookingRoom_API.Controllers
{
    [Route("api/reports")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<ReportResponseModel>> GetById([FromRoute] int id)
        {
            var result = await _reportService.GetById(id);
            if (result == null) { return NotFound(); }
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<ReportResponseModel>>> GetAll()
        {
            var result = await _reportService.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ReportResponseModel>> CreateReport([FromBody] CreateReportRequestModel add)
        {
            var result = await _reportService.AddAsync(add);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateReport([FromRoute]int id ,[FromBody] UpdateReportRequestModel update)
        {
            var result = await _reportService.UpdateAsync(id, update);
            if (result)
            {
            return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete("{id:int}")] 
        public async Task<ActionResult> DeleteReport([FromRoute]int id)
        {
            var result = await _reportService.DeleteAsync(id);
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
