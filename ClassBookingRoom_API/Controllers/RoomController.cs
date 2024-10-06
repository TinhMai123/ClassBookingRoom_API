using ClassBookingRoom_Repository.RequestModels.Room;
using ClassBookingRoom_Repository.RequestModels.RoomSlot;
using ClassBookingRoom_Repository.ResponseModels.Room;
using ClassBookingRoom_Repository.ResponseModels.RoomSlot;
using ClassBookingRoom_Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassBookingRoom_API.Controllers
{
    [Route("api/rooms")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IRoomSlotService _roomSlotService;

        public RoomController(IRoomService roomService, IRoomSlotService roomSlotService)
        {
            _roomService = roomService;
            _roomSlotService = roomSlotService;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<RoomResponseModel>> GetById([FromRoute] int id)
        {
            var result = await _roomService.GetRoom(id);
            if (result == null)
            {
                return NotFound();
            } else
            {
                return Ok(result);
            }
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult<RoomResponseModel>> UpdateRoom([FromRoute] int id, [FromBody] UpdateRoomRequestModel dto)
        {
            var result = await _roomService.UpdateRoomAsync(id, dto);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<ActionResult<RoomResponseModel>> CreateRoom([FromBody] CreateRoomRequestModel dto)
        {
            var result = await _roomService.AddRoomAsync(dto);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<RoomResponseModel>> DeleteRoom([FromRoute] int id)
        {
            var result = await _roomService.DeleteRoomAsync(id);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpGet]
        public async Task<ActionResult<List<RoomResponseModel>>> SearchRoom([FromQuery] SearchRoomQuery query)
        {
            try
            {
                var (rooms, totalCount) = await _roomService.SearchRoomQuery(query);
                var totalPages = (int)Math.Ceiling((double)totalCount / query.PageSize);
                Response.Headers.Append("X-Total-Count", totalCount.ToString());
                Response.Headers.Append("X-Current-Page", query.PageNumber.ToString());
                Response.Headers.Append("X-Total-Pages", totalPages.ToString());
                return Ok(rooms);
            } catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // ROOM SLOT

        [HttpGet("slots/{id:int}")]
        public async Task<ActionResult<RoomSlotResponseModel>> GetByRoomSlotId([FromRoute] int id)
        {
            var activity = await _roomSlotService.GetRoomSlot(id);
            if (activity == null) { return NotFound(); }
            return Ok(activity);
        }

        [HttpGet("slots")]
        public async Task<ActionResult<List<RoomSlotResponseModel>>> GetAllRoomSlot()
        {
            var list = await _roomSlotService.GetRoomSlots();
            return Ok(list);
        }
        [HttpGet("{roomId:int}/slots")]
        public async Task<ActionResult<List<RoomSlotResponseModel>>> GetRoomSlotsByRoomId([FromRoute]int roomId)
        {
            var list = await _roomSlotService.GetRoomSlotsByRoomId(roomId);
            return Ok(list);
        }

        [HttpPost("slots")]
        public async Task<ActionResult> CreateRoomSlot(CreateRoomSlotRequestModel add)
        {
            var result = await _roomSlotService.AddRoomSlotAsync(add);
            if (result)
            {
                return Ok();
            } else
            {
                return BadRequest();
            }

        }

        [HttpPut("slots/{id:int}")]
        public async Task<ActionResult> UpdateRoomSlot([FromRoute] int id, [FromBody] UpdateRoomSlotRequestModel update)
        {
            var result = await _roomSlotService.UpdateRoomSlotAsync(id, update);

            if (result)
            {
                return Ok();
            } else
            {
                return BadRequest();
            }
        }

        [HttpDelete("slots/{id:int}")]
        public async Task<ActionResult> DeleteRoomSlot([FromRoute] int id)
        {
            var result = await _roomSlotService.DeleteRoomSlotAsync(id);
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
