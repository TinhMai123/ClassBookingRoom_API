using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.Room
{
    public class UpdateRoomRequestModel
    {
        public string RoomName { get; set; } = string.Empty;
        public int Capacity { get; set; } = 0;
        public string? Status { get; set; }
        public int? RoomTypeId { get; set; }
    }
}
