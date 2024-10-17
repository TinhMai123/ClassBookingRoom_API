using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.ResponseModels.RoomSlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.Room
{
    public class RoomResponseModel : BaseModel
    {
        public int Id { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public int Capacity { get; set; } = 0;
        public string? Status { get; set; }
        public int? RoomTypeId { get; set; }
        public string RoomTypeName { get; set; } = string.Empty;
        public ICollection<SlotsForRoomResponseModel> RoomSlots { get; set; } = [];
    }
}
