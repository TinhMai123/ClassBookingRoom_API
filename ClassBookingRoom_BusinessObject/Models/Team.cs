using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Models
{
    public class Team : BaseModels
    {
        public int Id { get; set; } 
        public string? Status { get; set; }
        public ICollection<Booking>? Bookings { get; set;}
    }
}
