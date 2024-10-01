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
using ClassBookingRoom_Repository.RequestModels.Room;
using ClassBookingRoom_Service.Mappers;
using ClassBookingRoom_Repository.ResponseModels.Room;

namespace ClassBookingRoom_Service.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepo _repo;
        private readonly IBaseRepository<Room> _baseRepo;

        public RoomService(IRoomRepo repo, IBaseRepository<Room> baseRepo)
        {
            _repo = repo;
            _baseRepo = baseRepo;
        }
        public async Task<bool> AddRoomAsync(CreateRoomRequestModel dto)
        {
            return await _baseRepo.AddAsync(dto.ToRoomFromCreate());
        }

        public async Task<bool> DeleteRoomAsync(int id)
        {
            return await _baseRepo.DeleteAsync(id);
        }

        public async Task<RoomResponseModel?> GetRoom(int id)
        {
            var room = await _baseRepo.GetByIdAsync(id);
            return room?.ToRoomDTO();
        }

        

        public async Task<List<RoomResponseModel>> GetRooms()
        {
            var rooms = await _baseRepo.GetAllAsync();
            return rooms.Select(x => x.ToRoomDTO()).ToList(); 
        }

        public async Task<bool> UpdateRoomAsync(int id, UpdateRoomRequestModel update)
        {
            var room = await _baseRepo.GetByIdAsync(id);
            if (room is null) { return false; }
            room.UpdatedAt = DateTime.Now;
            room.Status = update.Status;
            room.Capacity = update.Capacity;
            room.RoomTypeId = update.RoomTypeId;
            room.RoomName = update.RoomName;
            return await _baseRepo.UpdateAsync(room); 
        }

        
    }
}
