using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject
{
    [Table("Rooms")]
    public class Room
    {
        public int Id { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public int RoomTypeId { get; set; }
        public int Capacity { get; set; } = 0;
        public RoomType? RoomType { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
