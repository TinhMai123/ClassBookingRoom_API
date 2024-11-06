using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.Room;
using ClassBookingRoom_Repository.ResponseModels.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.IRepos
{
    public interface IRoomRepo
    {
        Task<Room?> GetRoom(int id);
        Task<List<Room>> GetRooms();
        Task<List<Room>> GetAvailableRooms();
        Task<int> GetTotalRoom();

    }
}

