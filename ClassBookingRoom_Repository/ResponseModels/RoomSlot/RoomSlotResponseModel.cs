using ClassBookingRoom_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.RoomSlot
{
    public class RoomSlotResponseModel : BaseModel
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int RoomId { get; set; }
    }
}
