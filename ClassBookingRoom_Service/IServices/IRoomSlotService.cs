using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.RoomSlot;
using ClassBookingRoom_Repository.ResponseModels.RoomSlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface IRoomSlotService
    {
        Task<bool> AddRoomSlotAsync(CreateRoomSlotRequestModel add);
        Task<bool> DeleteRoomSlotAsync(int id);
        Task<RoomSlotResponseModel?> GetRoomSlot(int id);
        Task<List<RoomSlotResponseModel>> GetRoomSlots();
        Task<List<RoomSlotResponseModel>> GetRoomSlotsByRoomId(int roomId);
        Task<bool> UpdateRoomSlotAsync(int id ,UpdateRoomSlotRequestModel update);
    }
}
