using ClassBookingRoom_Repository.RequestModels.Activity;
using ClassBookingRoom_Repository.RequestModels.BookingModifyHistory;
using ClassBookingRoom_Repository.ResponseModels.Activity;
using ClassBookingRoom_Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassBookingRoom_API.Controllers
{
    [Route("api/booking-modify-histories")]
    [ApiController]
    public class BookingModifyHistoryController : ControllerBase
    {
        private readonly IBookingModifyHistoryService _historyService;
        public BookingModifyHistoryController(IBookingModifyHistoryService historyService)
        {
            _historyService = historyService;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<BookingModifyHistoryResponseModel>> GetById([FromRoute] int id)
        {
            var activity = await _historyService.Get(id);
            if (activity == null) { return NotFound(); }
            return Ok(activity);
        }

        [HttpGet]
        public async Task<ActionResult<List<BookingModifyHistoryResponseModel>>> GetAll()
        {
            var list = await _historyService.Gets();
            return Ok(list);
        }

        [HttpPost]
        public async Task<ActionResult> CreateActivity(CreateBookingModifyHistoryRequestModel add)
        {
            var result = await _historyService.AddAsync(add);
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
        public async Task<ActionResult> UpdateActivity([FromRoute] int id, [FromBody] UpdateBookingModifyHistoryRequestModel update)
        {
            var result = await _historyService.UpdateAsync(id, update);

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
            var result = await _historyService.DeleteAsync(id);
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
