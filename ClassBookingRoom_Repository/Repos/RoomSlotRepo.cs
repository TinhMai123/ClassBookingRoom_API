using ClassBookingRoom_Repository.Data;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Repos
{
    public class RoomSlotRepo : BaseRepository<RoomSlot>, IRoomSlotRepo
    {
        public RoomSlotRepo(AppDbContext context) : base(context)
        {
        }

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
