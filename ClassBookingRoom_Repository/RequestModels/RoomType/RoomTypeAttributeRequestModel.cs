using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.RoomType
{
    public class RoomTypeAttributeRequestModel
    {
        public int RoomTypeId { get; set; }
        public int ActivityId { get; set; }
        public int CohortId { get; set; }
    }
}
