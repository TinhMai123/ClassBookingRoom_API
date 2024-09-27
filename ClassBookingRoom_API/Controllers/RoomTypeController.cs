using ClassBookingRoom_BusinessObject.DTO.RoomType;
using ClassBookingRoom_Service.IServices;
using Microsoft.AspNetCore.Mvc;

namespace ClassBookingRoom_API.Controllers
{
    [Route("api/room-type")]
    [ApiController]
    public class RoomTypeController : Controller
    {
        private readonly IRoomTypeService roomTypeService;

        public RoomTypeController(IRoomTypeService roomTypeService)
        {
            this.roomTypeService = roomTypeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<RoomTypeDTO>>> GetAll()
        {
            var roomType = await roomTypeService.GetRoomTypes();
            return Ok(roomType);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<RoomTypeDTO>> GetById([FromRoute] int id)
        {
            var room = await roomTypeService.GetRoomType(id);
            if (room == null) { return NotFound(); }
            return Ok(room);
        }

        [HttpPost]
        public async Task<ActionResult> CreateRoomType([FromBody] CreateRoomTypeDTO add)
        {
            var result = await roomTypeService.AddRoomTypeAsync(add);
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
        public async Task<ActionResult> UpdateRoomType([FromRoute] int id, [FromBody] UpdateRoomTypeDTO update)
        {
            var result = await roomTypeService.UpdateRoomTypeAsync(id, update);
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
        public async Task<ActionResult> DeleteRoomType([FromRoute]int id)
        {
            var result = await roomTypeService.DeleteRoomTypeAsync(id);
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
