using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Models
{
    public class BookingDepartment
    {
        public string? Id { get; set; }
        public Booking? Booking { get; set; }
        public Department? Department { get; set; }
    }
}
