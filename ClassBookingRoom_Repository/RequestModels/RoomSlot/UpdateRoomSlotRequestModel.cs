using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.RoomSlot
{
    public class UpdateRoomSlotRequestModel
    {
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int RoomId { get; set; }
    }
}
