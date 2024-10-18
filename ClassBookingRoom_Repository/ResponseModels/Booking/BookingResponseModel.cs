using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.ResponseModels.RoomSlot;
using ClassBookingRoom_Repository.ResponseModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.Booking
{
    public class BookingResponseModel : BaseModel
    {
        public int Id { get; set; }
        public string Status { get; set; } = string.Empty;
        public Guid StudentId { get; set; }
        public string? CohortCode { get; set; }
        public string StudentFullName { get; set; } = string.Empty;
        public string StudentEmail { get; set; } = string.Empty;
        public int ActivityId { get; set; }
        public string Description { get; set; } = string.Empty;
        public ICollection<RoomSlotShortResponseModel>? RoomSlots { get; set; }
    }
}
