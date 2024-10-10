using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Models
{
    public class BaseModel
    {
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
        public DateTime? DeleteAt { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public bool isDeleted { get; set; } = false;

    }
}
