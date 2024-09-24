using ClassBookingRoom_BusinessObject.Models;
using ClassBookingRoom_Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Services
{
    public class RoomService : IRoomService
    {
        public Task<bool> AddRoomAsync(Room add)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRoomAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Room> GetRoom(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Room> GetRoomByRoomName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Room>> GetRooms()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRoomAsync(Room update)
        {
            throw new NotImplementedException();
        }
    }
}
