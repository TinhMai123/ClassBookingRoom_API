using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject
{
    [Table("Groups")]
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        //public List<RoomType> AllowedRoomTypes { get; set; } = [];
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
