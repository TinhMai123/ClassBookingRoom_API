using ClassBookingRoom_Repository.RequestModels.Activity;
using ClassBookingRoom_Repository.ResponseModels.Activity;
using ClassBookingRoom_Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassBookingRoom_API.Controllers
{
    [Route("api/activity")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityService _activityService;
        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ActivityResponseModel>> GetById([FromRoute] int id)
        {
            var activity = await _activityService.GetById(id);
            if (activity == null) { return NotFound(); }
            return Ok(activity);
        }

        [HttpGet]
        public async Task<ActionResult<List<ActivityResponseModel>>> GetAll()
        {
            var list = await _activityService.GetAll();
            return Ok(list);
        }

        [HttpPost]
        public async Task<ActionResult> CreateActivity(CreateActivityRequestModel add)
        {
            var result = await _activityService.CreateAsync(add);
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
        public async Task<ActionResult> UpdateActivity([FromRoute] int id, [FromBody] UpdateActivityRequestModel update)
        {
            var result = await _activityService.UpdateAsync(id, update);

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
        public async Task<ActionResult> DeleteActivity([FromRoute] int id)
        {
            var result = await _activityService.DeleteAsync(id);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
