﻿using ClassBookingRoom_Repository.RequestModels.Room;
using ClassBookingRoom_Repository.RequestModels.RoomSlot;
using ClassBookingRoom_Repository.ResponseModels.Booking;
using ClassBookingRoom_Repository.ResponseModels.Report;
using ClassBookingRoom_Repository.ResponseModels.Room;
using ClassBookingRoom_Repository.ResponseModels.RoomSlot;
using ClassBookingRoom_Service.IServices;
using ClassBookingRoom_Service.Services;
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
        private readonly IBookingService _bookingService;

        public RoomController(IRoomService roomService, IRoomSlotService roomSlotService, IBookingService bookingService)
        {
            _roomService = roomService;
            _roomSlotService = roomSlotService;
            _bookingService = bookingService;
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
            try
            {
                var result = await _roomService.UpdateRoomAsync(id, dto);
                if (result)
                {
                    return Ok("Update successfully");
                }
                return BadRequest();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<RoomResponseModel>> CreateRoom([FromBody] CreateRoomRequestModel dto)
        {
            try
            {
                var result = await _roomService.AddRoomAsync(dto);
                if (result)
                {
                    return Ok("Room added successfully");
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  
            }
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
        [HttpPost("available")]
        public async Task<ActionResult<List<RoomResponseModel>>> SearchRoomForUser([FromBody] GetAvailableRoomsRequest request)
        {
            try
            {
                var  rooms = await _roomService.GetAvailableRooms(request);
                return Ok(rooms);
            } catch (Exception ex) { return BadRequest(ex.Message); }
        }
        [HttpGet]
        public async Task<ActionResult<List<RoomResponseModel>>> SearchRoomForAdmin([FromQuery] SearchRoomQuery query)
        {
            try
            {
                var (rooms, totalCount) = await _roomService.SearchRoomAdmin(query);
                var totalPages = (int)Math.Ceiling((double)totalCount / query.PageSize);
                Response.Headers.Append("X-Total-Count", totalCount.ToString());
                Response.Headers.Append("X-Current-Page", query.PageNumber.ToString());
                Response.Headers.Append("X-Total-Pages", totalPages.ToString());
                return Ok(rooms);
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
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
        public async Task<ActionResult<List<RoomSlotResponseModel>>> GetRoomSlotsByRoomId([FromRoute] int roomId)
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
        [HttpGet("{roomId:int}/bookings")]
        public async Task<ActionResult<List<BookingResponseModel>>> GetBookingsByRoomId([FromRoute] int roomId)
        {
            var list = await _roomService.GetBookingsByRoomId(roomId);
            return Ok(list);
        }
        [HttpGet("{roomId:int}/today-bookings")]
        public async Task<ActionResult<List<BookingDetailResponse>>> GetTodayBookingsByRoomId([FromRoute] int roomId)
        {
            var list = await _bookingService.GetRecentBookingsByRoomId(roomId);
            return Ok(list);
        }
        [HttpGet("{roomId:int}/reports")]
        public async Task<ActionResult<List<ReportResponseModel>>> GetReportsByRoomId([FromRoute] int roomId)
        {
            var list = await _roomService.GetReportsByRoomId(roomId);
            return Ok(list);
        }

        [HttpGet("total-rooms")]
        public async Task<ActionResult<int>> GetTotalRoom()
        {
            int totalRoom = await _roomService.GetTotalRoom();
            return Ok(totalRoom);
        }
    }
}
