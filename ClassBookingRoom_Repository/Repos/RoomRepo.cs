using ClassBookingRoom_Repository.Data;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.Report;
using ClassBookingRoom_Repository.RequestModels.Room;
using ClassBookingRoom_Repository.ResponseModels.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Repos
{
    public class RoomRepo : BaseRepository<Room>, IRoomRepo
    {
        public RoomRepo(AppDbContext context) : base(context)
        {
        }

        public Task<bool> AddRoomAsync(CreateReportRequestModel add)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddRoomAsync(CreateRoomRequestModel add)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRoomAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<RoomResponseModel> GetRoom(int id)
        {
            throw new NotImplementedException();
        }

       

        public Task<List<RoomResponseModel>> GetRooms()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRoomAsync(int id, UpdateRoomRequestModel update)
        {
            throw new NotImplementedException();
        }
    }
}
