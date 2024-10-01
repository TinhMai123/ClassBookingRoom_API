using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Models
{
    [Table("ActivityType")]
    public class ActivityType : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Activity> Activities { get; set; } = [];
        public ICollection<RoomType> RoomTypes { get; set; } = [];
    }
}
