using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.Booking
{
    public class UpdateBookingRequestModel
    {
        public string Status { get; set; } = string.Empty;
        public Guid UserId { get; set; }
        public int ActivityId { get; set; }
        public string Description { get; set; } = string.Empty;
        public ICollection<int> RoomSlots { get; set; } = [];
    }
}
