using ClassBookingRoom_BusinessObject.Models;
using ClassBookingRoom_Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Services
{
    public class RoomSlotService : IRoomSlotService
    {
        public Task<bool> AddRoomSlotAsync(RoomSlot add)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRoomSlotAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<RoomSlot> GetRoomSlot(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<RoomSlot>> GetRoomSlots()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRoomSlotAsync(RoomSlot update)
        {
            throw new NotImplementedException();
        }
    }
}
