using ClassBookingRoom_Repository.Data;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ClassBookingRoom_Repository.Repos
{
    public class RoomRepo : BaseRepository<Room>, IRoomRepo
    {
        public RoomRepo(AppDbContext context) : base(context)
        {
        }

        public async Task<Room?> GetRoom(int id)
        {
            return await _context.Rooms
                .Include(r => r.RoomType)
                .Include(r => r.RoomSlots)
                .SingleOrDefaultAsync(r => r.Id == id);
        }

        public async Task<List<Room>> GetRooms()
        {
            return await _context.Rooms
                .Include(r => r.RoomType)
                .Include(r => r.RoomSlots)
                .ToListAsync();
        }
    }
}
