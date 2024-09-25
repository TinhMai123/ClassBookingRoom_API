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
    public class RoomSlotService : IRoomSlotService
    {
        private readonly IRoomSlotRepo _repo;
        private readonly BaseIRepository<RoomSlot> _baseRepo;
        private IConfiguration _configuration;

        public RoomSlotService(IRoomSlotRepo repo, BaseIRepository<RoomSlot> baseRepo, IConfiguration configuration)
        {
            _repo = repo;
            _baseRepo = baseRepo;
            _configuration = configuration;
        }
        public async Task<bool> AddRoomSlotAsync(RoomSlot add)
        {
            return await _repo.AddRoomSlotAsync(add);
        }

        public async Task<bool> DeleteRoomSlotAsync(int id)
        {
            return await (_repo.DeleteRoomSlotAsync(id));
        }

        public Task<RoomSlot> GetRoomSlot(int id)
        {
            return _repo.GetRoomSlot(id);
        }

        public Task<List<RoomSlot>> GetRoomSlots()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateRoomSlotAsync(RoomSlot update)
        {
            return await _repo.UpdateRoomSlotAsync(update);
        }
    }
}
