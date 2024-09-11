using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject
{
    [Table("RoomTypes")]
    public class RoomType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Room> Rooms { get; set; } = [];
        public List<Group> AllowedGroup { get; set; } = [];
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
