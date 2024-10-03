using ClassBookingRoom_Repository.RequestModels.Activity;
using ClassBookingRoom_Repository.RequestModels.Room;
using ClassBookingRoom_Repository.RequestModels.RoomSlot;
using ClassBookingRoom_Repository.ResponseModels.Activity;
using ClassBookingRoom_Repository.ResponseModels.RoomSlot;
using ClassBookingRoom_Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassBookingRoom_API.Controllers
{
    [Route("api/roomslots")]
    [ApiController]
    public class RoomSlotController : ControllerBase
    {
        private readonly IRoomSlotService _roomSlotService ;
        public RoomSlotController(IRoomSlotService roomSlotService)
        {
            _roomSlotService = roomSlotService;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<RoomSlotResponseModel>> GetById([FromRoute] int id)
        {
            var activity = await _roomSlotService.GetRoomSlot(id);
            if (activity == null) { return NotFound(); }
            return Ok(activity);
        }

        [HttpGet]
        public async Task<ActionResult<List<RoomSlotResponseModel>>> GetAll()
        {
            var list = await _roomSlotService.GetRoomSlots();
            return Ok(list);
        }

        [HttpPost]
        public async Task<ActionResult> CreateRoomSlot(CreateRoomSlotRequestModel add)
        {
            var result = await _roomSlotService.AddRoomSlotAsync(add);
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
        public async Task<ActionResult> UpdateRoomSlot([FromRoute] int id, [FromBody] UpdateRoomSlotRequestModel update)
        {
            var result = await _roomSlotService.UpdateRoomSlotAsync(id, update);

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
        public async Task<ActionResult> DeleteRoomSlot([FromRoute] int id)
        {
            var result = await _roomSlotService.DeleteRoomSlotAsync(id);
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
