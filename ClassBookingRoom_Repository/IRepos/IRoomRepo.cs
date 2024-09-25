using ClassBookingRoom_BusinessObject;
using ClassBookingRoom_BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.IRepos
{
    public interface IRoomRepo
    {
        Task<bool> AddRoomAsync(Room add);
        Task<bool> DeleteRoomAsync(int id);
        Task<Room> GetRoom(int id);
        Task<List<Room>> GetRooms();
        Task<Room> GetRoomByRoomName(string name);
        Task<bool> UpdateRoomAsync(Room update);
    }
}

