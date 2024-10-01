using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.Cohort;
using ClassBookingRoom_Repository.ResponseModels.Cohort;
using ClassBookingRoom_Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassBookingRoom_API.Controllers
{
    [Route("api/cohorts")]
    [ApiController]
    public class CohortController : ControllerBase
    {
        private readonly ICohortService _cohortService;

        public CohortController(ICohortService cohortService)
        {
            _cohortService = cohortService;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CohortResponseModel>> GetById([FromRoute] int id)
        {
            var result = await _cohortService.GetCohort(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<CohortResponseModel>>> GetAll()
        {
            var result = await _cohortService.GetCohorts();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<CohortResponseModel>> CreateCohort([FromBody] CreateCohortRequestModel dto)
        {
            var result = await _cohortService.AddCohortAsync(dto);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut ("{id:int}")]
        public async Task<ActionResult<CohortResponseModel>> UpdateCohort([FromRoute]int id,[FromBody]UpdateCohortRequestModel update)
        {
            var result = await _cohortService.UpdateCohortAsync(id, update);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<CohortResponseModel>> DeleteCohort(int id)
        {
            var result = await _cohortService.DeleteCohortAsync(id);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
