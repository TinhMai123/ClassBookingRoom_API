using ClassBookingRoom_BusinessObject.Models;
using ClassBookingRoom_Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        public Task<bool> AddRoomTypeAsync(RoomType add)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRoomTypeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<RoomType> GetRoomByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Room> GetRoomType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<RoomType>> GetRoomTypes()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRoomTypeAsync(RoomType update)
        {
            throw new NotImplementedException();
        }
    }
}
