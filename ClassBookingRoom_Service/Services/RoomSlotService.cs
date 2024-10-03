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
using ClassBookingRoom_Repository.RequestModels.RoomSlot;
using ClassBookingRoom_Repository.ResponseModels.RoomSlot;
using ClassBookingRoom_Service.Mappers;

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
        public async Task<bool> AddRoomSlotAsync(CreateRoomSlotRequestModel add)
        {
            return await _baseRepo.AddAsync(add.ToActivityFromCreate());
        }

        public async Task<bool> DeleteRoomSlotAsync(int id)
        {
            return await _baseRepo.DeleteAsync(id);
        }

        public async Task<RoomSlotResponseModel?> GetRoomSlot(int id)
        {
            var result = await _baseRepo.GetByIdAsync(id);
            return result?.ToRoomSlotDTO();
        }

        public async Task<List<RoomSlotResponseModel>> GetRoomSlots()
        {
            var result = await _baseRepo.GetAllAsync();
            return result.Select(x => x.ToRoomSlotDTO()).ToList();
        }

        public async Task<bool> UpdateRoomSlotAsync(int id,UpdateRoomSlotRequestModel update)
        {
            var result = await _baseRepo.GetByIdAsync(id);
            if (result is null) { return false; }
            result.StartTime = update.StartTime;
            result.EndTime = update.EndTime;
            result.RoomId = update.RoomId;
            result.UpdatedAt=DateTime.Now;
            return await _baseRepo.UpdateAsync(result);
        }
    }
}
