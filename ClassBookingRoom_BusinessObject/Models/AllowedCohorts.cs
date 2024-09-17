using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Models
{
    public class AllowedCohorts
    {
        public int Id { get; set; }
        public RoomType? RoomType { get; set; }
        public Cohort? Cohort { get; set; }
    }
}
