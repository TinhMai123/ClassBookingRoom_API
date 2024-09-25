using ClassBookingRoom_BusinessObject.Models;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository;
using ClassBookingRoom_Service.IServices;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IRoomTypeRepo _repo;
        private readonly BaseIRepository<RoomType> _baseRepo;
        private IConfiguration _configuration;

        public RoomTypeService(IRoomTypeRepo repo, BaseIRepository<RoomType> baseRepo, IConfiguration configuration)
        {
            _repo = repo;
            _baseRepo = baseRepo;
            _configuration = configuration;
        }
        public async Task<bool> AddRoomTypeAsync(RoomType add)
        {
            return await _repo.AddRoomTypeAsync(add);
        }

        public async Task<bool> DeleteRoomTypeAsync(int id)
        {
            var de = await _baseRepo.DeleteAsync(id);
            return de;
        }

        public async Task<RoomType> GetRoomTypeByName(string name)
        {
            return await _repo.GetRoomTypeByName(name);
        }

        public Task<RoomType> GetRoomType(int id)
        {
            return _repo.GetRoomType(id);
        }

        public Task<List<RoomType>> GetRoomTypes()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateRoomTypeAsync(RoomType update)
        {
            return await _repo.UpdateRoomTypeAsync(update);
        }
    }
}
