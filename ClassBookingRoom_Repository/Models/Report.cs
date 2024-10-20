using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Models
{
    [Table("Report")]

    public class Report : BaseModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending";
        public string? Response { get; set; }
        public int RoomId { get; set; }
        public Guid CreatorId { get; set; }
        public Room? Room { get; set; }
        public User? CreatedBy { get; set; }
    }
}
