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
    public class RoomService : IRoomService
    {
        private readonly IRoomRepo _repo;
        private readonly IBaseRepository<Room> _baseRepo;
        private IConfiguration _configuration;

        public RoomService(IRoomRepo repo, IBaseRepository<Room> baseRepo, IConfiguration configuration)
        {
            _repo = repo;
            _baseRepo = baseRepo;
            _configuration = configuration;
        }
        public async Task<bool> AddRoomAsync(Room add)
        {
            return await _repo.AddRoomAsync(add);
        }

        public async Task<bool> DeleteRoomAsync(int id)
        {
            return await (_repo.DeleteRoomAsync(id));
        }

        public Task<Room> GetRoom(int id)
        {
            return _repo.GetRoom(id);
        }

        public Task<Room> GetRoomByRoomName(string name)
        {
            return _repo.GetRoomByRoomName(name);
        }

        public Task<List<Room>> GetRooms()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateRoomAsync(Room update)
        {
            return await _repo.UpdateRoomAsync(update); 
        }
    }
}
