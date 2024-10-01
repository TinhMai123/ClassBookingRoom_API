using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository;
using ClassBookingRoom_Service.IServices;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassBookingRoom_Repository.Models;

namespace ClassBookingRoom_Service.Services
{
    public class RoomSlotService : IRoomSlotService
    {
        private readonly IRoomSlotRepo _repo;
        private readonly IBaseRepository<RoomSlot> _baseRepo;
        public RoomSlotService(IRoomSlotRepo repo, IBaseRepository<RoomSlot> baseRepo)
        {
            _repo = repo;
            _baseRepo = baseRepo;
        }
        public async Task<bool> AddRoomSlotAsync(RoomSlot add)
        {
            return await _baseRepo.AddAsync(add);
        }

        public async Task<bool> DeleteRoomSlotAsync(int id)
        {
            return await _baseRepo.DeleteAsync(id);
        }

        public async Task<RoomSlot?> GetRoomSlot(int id)
        {
            return await _baseRepo.GetByIdAsync(id);
        }

        public async Task<List<RoomSlot>> GetRoomSlots()
        {
            return await _baseRepo.GetAllAsync();
        }

        public async Task<bool> UpdateRoomSlotAsync(RoomSlot update)
        {
            return await _baseRepo.UpdateAsync(update);
        }
    }
}
