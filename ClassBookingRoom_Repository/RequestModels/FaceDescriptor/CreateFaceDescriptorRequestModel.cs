using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.FaceDescriptor
{
    public class CreateFaceDescriptorRequestModel
    {
        public Guid? UserId { get; set; }
        public ICollection<double> Descriptor { get; set; } = [];
        public string ImageURL { get; set; } = string.Empty;
    }
}
