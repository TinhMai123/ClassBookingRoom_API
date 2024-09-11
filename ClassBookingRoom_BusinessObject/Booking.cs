using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject
{
    [Table("Bookings")]
    public class Booking
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int RoomId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string Status {  get; set; } = string.Empty;
        public User? User { get; set; }
        public Room? Room { get; set; }
    }
}
