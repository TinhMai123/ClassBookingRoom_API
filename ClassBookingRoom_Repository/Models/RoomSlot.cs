using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Models
{
    [Table("RoomSlot")]
    public class RoomSlot
    {
        public int Id { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int RoomId { get; set; }
        public Room? Room { get; set; }
        public IEnumerable<Booking>? Bookings { get; set; }
    }
}
