using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.Report;
using ClassBookingRoom_Repository.ResponseModels.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface IFaceDescriptorService
    {
        Task AddAsync(FaceDescriptor add);
        Task DeleteAsync(int id);
        Task<FaceDescriptor?> GetById(int id);
        Task<List<FaceDescriptor>> GetAll();
        Task UpdateAsync(FaceDescriptor update);
    }
}
