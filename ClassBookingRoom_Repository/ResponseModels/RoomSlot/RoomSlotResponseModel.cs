using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.RoomSlot
{
    public class RoomSlotResponseModel
    {
        public int Id { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int RoomId { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime? DeleteAt { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
