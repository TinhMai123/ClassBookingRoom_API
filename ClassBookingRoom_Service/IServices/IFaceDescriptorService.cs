using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.FaceDescriptor;
using ClassBookingRoom_Repository.RequestModels.Report;
using ClassBookingRoom_Repository.ResponseModels.FaceDescriptor;
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
        Task AddAsync(CreateFaceDescriptorRequestModel add);
        Task DeleteAsync(int id);
        Task<FaceDescriptorResponseModel?> GetById(int id);
        Task<FaceDescriptorResponseModel?> GetByUserId(Guid userId);
        Task<List<FaceDescriptorResponseModel>> GetAll();
        Task UpdateAsync(UpdateFaceDescriptorRequestModel update);
    }
}
