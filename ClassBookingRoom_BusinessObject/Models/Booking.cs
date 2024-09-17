using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Models
{
    [Table("Bookings")]
    public class Booking : BaseModels
    {
        public int Id { get; set; }
        public string Status { get; set; } = string.Empty;
        public User? CreateBy {  get; set; }
        public Team? Team { get; set; }
        public Room? Room { get; set; }
        public Slot? Slot { get; set; }
    }
}
