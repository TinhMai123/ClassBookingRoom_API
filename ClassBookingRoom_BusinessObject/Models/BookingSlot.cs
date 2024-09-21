using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Models
{
    [Table("BookingSlot")]
    public class BookingSlot
    {
        public int Id { get; set; }
        public Booking? Booking { get; set; }
        public RoomSlot? RoomSlot { get; set; }
    }
}
