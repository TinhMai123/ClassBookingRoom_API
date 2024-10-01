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
        Task<bool> AddRoomAsync(CreateRoomRequestModel add);
        Task<bool> DeleteRoomAsync(int id);
        Task<RoomResponseModel> GetRoom(int id);
        Task<List<RoomResponseModel>> GetRooms();
        Task<bool> UpdateRoomAsync(int id,UpdateRoomRequestModel update);
    }
}

