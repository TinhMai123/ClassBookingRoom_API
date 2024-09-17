using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Models
{
    public class Slot : BaseModels
    {
        public int Id { get; set; }
        public decimal duration { get; set; }
        public TimeOnly StartTime { get; set; }
        public ICollection<Booking>? Bookings { get; set; }
    }
}
