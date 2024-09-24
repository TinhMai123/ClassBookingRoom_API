using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Models
{
    [Table("Room")]
    public class Room : BaseModels
    {
        public int Id { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public int Capacity { get; set; } = 0;
        public string? Status { get; set; }
        public RoomType? RoomType { get; set; }
        public ICollection<Booking>? Bookings { get; set; }
        public ICollection<Report>? Reports { get; set; }
        public ICollection<RoomSlot>? RoomSlots { get; set; }

    }
}
