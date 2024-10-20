using ClassBookingRoom_Repository.RequestModels.RoomType;
using ClassBookingRoom_Repository.RequestModels.User;
using ClassBookingRoom_Repository.ResponseModels.RoomType;
using ClassBookingRoom_Repository.ResponseModels.User;
using ClassBookingRoom_Service.IServices;
using ClassBookingRoom_Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClassBookingRoom_API.Controllers
{
    [Route("api/room-types")]
    [ApiController]
    public class RoomTypeController : Controller
    {
        private readonly IRoomTypeService roomTypeService;

        public RoomTypeController(IRoomTypeService roomTypeService)
        {
            this.roomTypeService = roomTypeService;
        }

/*        [HttpGet]
        public async Task<ActionResult<List<RoomTypeResponseModel>>> GetAll()
        {
            var roomType = await roomTypeService.GetRoomTypes();
            return Ok(roomType);
        }*/

        [HttpGet("{id:int}")]
        public async Task<ActionResult<RoomTypeResponseModel>> GetById([FromRoute] int id)
        {
            var room = await roomTypeService.GetRoomType(id);
            if (room == null) { return NotFound(); }
            return Ok(room);
        }

        [HttpPost]
        public async Task<ActionResult> CreateRoomType([FromBody] CreateRoomTypeRequestModel add)
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
        public async Task<ActionResult> UpdateRoomType([FromRoute] int id, [FromBody] UpdateRoomTypeRequestModel update)
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
        [HttpGet]
        public async Task<ActionResult<List<RoomTypeResponseModel>>> SearchRoomType([FromQuery] SearchRoomTypeQuery query)
        {
            var (roomTypes, totalCount) = await roomTypeService.SearchRoomType(query);
            var totalPages = (int)Math.Ceiling((double)totalCount / query.PageSize);
            Response.Headers.Append("X-Total-Count", totalCount.ToString());
            Response.Headers.Append("X-Current-Page", query.PageNumber.ToString());
            Response.Headers.Append("X-Total-Pages", totalPages.ToString());
            return Ok(roomTypes);
        }
        [HttpDelete("{id:int}/cohort")]
        public async Task<ActionResult> RemoveRoomTypeCohort([FromRoute]int id, [FromBody]int cohortId)
        {
            try
            {
                await roomTypeService.RemoveCohort(id, cohortId);
                return Ok("Remove successfully");

            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
        [HttpPut("{id:int}/cohort")]
        public async Task<ActionResult> AddRoomTypeCohort([FromRoute] int id, [FromBody] int cohortId)
        {
            try
            {
                await roomTypeService.AddCohort(id, cohortId);
                return Ok("Added successfully");

            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
        [HttpDelete("{id:int}/activity")]
        public async Task<ActionResult> RemoveRoomTypeActivity([FromRoute] int id, [FromBody] int activityId)
        {
            try
            {
                await roomTypeService.RemoveActivity(id, activityId);
                return Ok("Remove successfully");

            } catch (Exception ex) { return BadRequest(ex.Message); }
        }
        [HttpPut("{id:int}/activity")]
        public async Task<ActionResult> AddRoomTypeActivity([FromRoute] int id, [FromBody] int activityId)
        {
            try
            {
                await roomTypeService.AddActivity(id, activityId);
                return Ok("Added successfully");

            } catch (Exception ex) { return BadRequest(ex.Message); }
        }
    }
}
