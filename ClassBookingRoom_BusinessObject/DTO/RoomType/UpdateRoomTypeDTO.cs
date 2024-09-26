using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.DTO.RoomType
{
    public class UpdateRoomTypeDTO
    {
        public string Name { get; set; } = string.Empty;
        public int DepartmentId { get; set; }
    }
}
