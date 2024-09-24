using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Models
{
    [Table("Booking")]
    public class Booking : BaseModels
    {
        public int Id { get; set; }
        public string Status { get; set; } = string.Empty;
        public User? CreateBy {  get; set; }
        public Room? Room { get; set; }
        public ICollection<BookingSlot>? BookingSlots { get; set; }
        public ICollection<BookingActivity>? BookingActivities { get; set; }
    }
}
