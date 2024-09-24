using ClassBookingRoom_BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface IRoomTypeService
    {
        Task<bool> AddRoomTypeAsync(RoomType add);
        Task<bool> DeleteRoomTypeAsync(int id);
        Task<Room> GetRoomType(int id);
        Task<List<RoomType>> GetRoomTypes();
        Task<RoomType> GetRoomByName(string name);
        Task<bool> UpdateRoomTypeAsync(RoomType update);
    }
}
