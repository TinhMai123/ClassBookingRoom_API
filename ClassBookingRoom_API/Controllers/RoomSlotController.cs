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

       
    }
}
