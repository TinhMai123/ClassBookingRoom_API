using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.Room
{
    public class GetAvailableRoomsRequest
    {
        public int ActivityId { get; set; }
        public int CohortId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime BookingDate { get; set; }
    }
}
