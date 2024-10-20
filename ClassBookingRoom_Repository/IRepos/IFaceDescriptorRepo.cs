using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.ResponseModels.FaceDescriptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.IRepos
{
    public interface IFaceDescriptorRepo
    {
        Task<FaceDescriptor?> GetByUserId(Guid userId);
    }
}
