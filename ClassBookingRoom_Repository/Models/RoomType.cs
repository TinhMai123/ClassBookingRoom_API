using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Models
{
    [Table("RoomType")]
    public class RoomType : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Room> Rooms { get; set; } = [];
        public ICollection<Cohort> AllowedCohorts { get; set; } = [];
        public ICollection<ActivityType> ActivityTypes { get; set; } = [];
    }
}
