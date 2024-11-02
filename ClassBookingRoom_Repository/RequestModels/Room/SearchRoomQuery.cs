using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.Room
{
    public class SearchRoomQuery
    {
        public string SearchValue { get; set; } = string.Empty;
        public int? RoomTypeId { get; set; }
        public string Status { get; set; } = string.Empty;
        public string ActivityCode { get; set; } = string.Empty;
        public string CohortCode { get; set; } = string.Empty;
        public int? MinCapacity { get; set; } = 0; 
        public int? MaxCapacity { get; set; } = int.MaxValue; 
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? BookingDate { get; set; } 
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
