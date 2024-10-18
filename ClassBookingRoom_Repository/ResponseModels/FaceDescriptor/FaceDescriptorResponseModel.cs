using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.FaceDescriptor
{
    public class FaceDescriptorResponseModel
    {
        public int Id { get; set; }
        public Guid? UserId { get; set; }
        public ICollection<double> Descriptor { get; set; } = [];
        public string ImageURL { get; set; } = string.Empty;
    }
}
