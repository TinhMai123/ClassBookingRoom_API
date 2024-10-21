using ClassBookingRoom_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.IRepos
{
    public interface IRoomTypeRepo
    {
        Task<RoomType> GetRoomTypeByName(string name);
        Task<RoomType?> GetRoomTypeById(int id);
        Task<List<RoomType>> GetRoomTypes();
    }
}
