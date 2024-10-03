using ClassBookingRoom_Repository.ResponseModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.Booking
{
    public class BookingResponseModel
    {
        public int Id { get; set; }
        public string Status { get; set; } = string.Empty;
        public Guid UserId { get; set; }
        public int ActivityId { get; set; }
        public UserResponseModel? CreateBy { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime? DeleteAt { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
