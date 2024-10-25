using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.RoomSlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.Booking
{
    public class CreateBookingRequestModel
    {
        public string Status { get; set; } = string.Empty;
        public Guid UserId { get; set; }
        public int ActivityId { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime BookingDate { get; set; } = DateTime.Now;
        public ICollection<int> RoomSlots { get; set; } = [];
    }
}
