using ClassBookingRoom_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface IRoomSlotService
    {
        Task<bool> AddRoomSlotAsync(RoomSlot add);
        Task<bool> DeleteRoomSlotAsync(int id);
        Task<RoomSlot?> GetRoomSlot(int id);
        Task<List<RoomSlot>> GetRoomSlots();
        Task<bool> UpdateRoomSlotAsync(RoomSlot update);
    }
}
