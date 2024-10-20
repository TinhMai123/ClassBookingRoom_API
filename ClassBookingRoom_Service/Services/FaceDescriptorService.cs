using ClassBookingRoom_Repository;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.FaceDescriptor;
using ClassBookingRoom_Repository.ResponseModels.FaceDescriptor;
using ClassBookingRoom_Service.IServices;
using ClassBookingRoom_Service.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Services
{
    public class FaceDescriptorService : IFaceDescriptorService
    {
        private readonly IFaceDescriptorRepo _repo;
        private readonly IBaseRepository<FaceDescriptor> _baseRepo;

        public FaceDescriptorService(IFaceDescriptorRepo repo, IBaseRepository<FaceDescriptor> baseRepo)
        {
            _repo = repo;
            _baseRepo = baseRepo;
        }

        public async Task AddAsync(CreateFaceDescriptorRequestModel add)
        {
            await _baseRepo.AddAsync(add.ToCreateFaceDescriptorDTO());
        }

        public async Task DeleteAsync(int id)
        {
            await _baseRepo.DeleteAsync(id);
        }

        public async Task<List<FaceDescriptorResponseModel>> GetAll()
        {
           var list = await _baseRepo.GetAllAsync();
            return list.Select(c=>c.ToFaceDescriptorDTO()).ToList();
        }

        public async Task<FaceDescriptorResponseModel?> GetById(int id)
        {
           var model = await _baseRepo.GetByIdAsync(id);
            return model?.ToFaceDescriptorDTO() ?? null;
        }

        public async Task<FaceDescriptorResponseModel?> GetByUserId(Guid userId)
        {
            var model = await _repo.GetByUserId(userId);
            return model?.ToFaceDescriptorDTO() ?? null;
        }

        public async Task UpdateAsync(UpdateFaceDescriptorRequestModel update)
        {
            await _baseRepo.UpdateAsync(update.ToUpdateFaceDescriptor());
        }
    }
}
