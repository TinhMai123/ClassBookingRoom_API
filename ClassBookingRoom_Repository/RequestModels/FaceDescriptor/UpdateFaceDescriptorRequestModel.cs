using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.FaceDescriptor
{
    public class UpdateFaceDescriptorRequestModel
    {
        public int Id { get; set; }
        public IList<double> Descriptor { get; set; } = [];
        public string ImageURL { get; set; } = string.Empty;
    }
}
