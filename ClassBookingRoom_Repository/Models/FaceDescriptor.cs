using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Models
{
    public class FaceDescriptor : BaseModel
    {
        public int Id { get; set; }
        public Guid? UserId { get; set; }
        public ICollection<double>? Descriptor { get; set; }
        public User? User { get; set; }
    }
}
