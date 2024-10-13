using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.RoomType
{
    public class SearchRoomTypeQuery
    {
        public string? SearchValue { get; set; }
        public string? CohortCode { get; set; }
        public string? ActivityName { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
