using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.RoomType
{
    public class CreateRoomTypeRequestModel
    {
        public string Name { get; set; } = string.Empty;
        public int DepartmentId { get; set; }
    }
}
