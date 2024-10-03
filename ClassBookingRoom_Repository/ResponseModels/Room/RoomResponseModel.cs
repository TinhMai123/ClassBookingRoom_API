using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.Room
{
    public class RoomResponseModel
    {
        public int Id { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public int Capacity { get; set; } = 0;
        public string? Status { get; set; }
        public int? RoomTypeId { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime? DeleteAt { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
