using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Models
{
    [Table("Booking")]
    public class Booking : BaseModel
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public Guid UserId { get; set; }
        public int ActivityId { get; set; }
        public User? CreateBy { get; set; }
        public string Description { get; set; } = string.Empty;
        public string? Response { get; set; }
        public ICollection<RoomSlot>? RoomSlots { get; set; }
        public Activity? Activity { get; set; }
    }
}
