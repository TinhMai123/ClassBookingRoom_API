using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.FaceDescriptor
{
    public class FaceDescriptorShortResponse
    {
        public int Id { get; set; }
        public Guid? UserId { get; set; }
        public IList<double> Descriptor { get; set; } = [];
        public string ImageURL { get; set; } = string.Empty;
    }
}
