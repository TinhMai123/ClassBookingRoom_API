using ClassBookingRoom_Repository.RequestModels.Room;
using ClassBookingRoom_Repository.ResponseModels.Room;
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

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public async Task<ActionResult<List<RoomResponseModel>>> GetAll()
        {
            var result = await _roomService.GetRooms();
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<RoomResponseModel>> GetById([FromRoute] int id)
        {
            var result = await _roomService.GetRoom(id);
            if (result == null)
            {
                return NotFound();
            }
            else
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
        [HttpPost("search")]
        public async Task<ActionResult<RoomResponseModel>> SearchRoom([FromBody] SearchRoomQuery query)
        {
            var (rooms, totalCount) = await _roomService.SearchRoomQuery(query);
            var totalPages = (int)Math.Ceiling((double)totalCount / query.PageSize);
            Response.Headers.Append("X-Total-Count", totalCount.ToString());
            Response.Headers.Append("X-Current-Page", query.PageNumber.ToString());
            Response.Headers.Append("X-Total-Pages", totalPages.ToString());
            return Ok(rooms);
        }
    }
}
