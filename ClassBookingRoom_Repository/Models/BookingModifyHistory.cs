using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Models
{
    [Table("BookingModifyHistory")]
    public class BookingModifyHistory : BaseModel
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public Booking? Booking { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid ModifiedById { get; set; }
        public User? ModifiedBy { get; set; }
        public string OldStatus { get; set; } = string.Empty;
        public string NewStatus { get; set; } = string.Empty;
    }
}
