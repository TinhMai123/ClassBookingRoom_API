using ClassBookingRoom_Repository;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Service.IServices;
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

        public async Task AddAsync(FaceDescriptor add)
        {
            await _baseRepo.AddAsync(add);
        }

        public async Task DeleteAsync(int id)
        {
            await _baseRepo.DeleteAsync(id);
        }

        public async Task<List<FaceDescriptor>> GetAll()
        {
           return await _baseRepo.GetAllAsync();
        }

        public async Task<FaceDescriptor?> GetById(int id)
        {
           return await _baseRepo.GetByIdAsync(id);
        }

        public async Task UpdateAsync(FaceDescriptor update)
        {
            await _baseRepo.UpdateAsync(update);
        }
    }
}
