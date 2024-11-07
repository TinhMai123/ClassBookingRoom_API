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

        public async Task<List<Room>> GetAvailableRooms()
        {
            return await _context.Rooms
                .Where(r => r.IsDeleted == false && r.Status == "Active")
                .Include(r => r.RoomType)
                .Include(r => r.RoomType.AllowedCohorts)
                .Include(r => r.RoomType.Activities)
                .Include(r => r.RoomSlots)
                .Where(r => r.RoomSlots.Count() > 0)
                .ToListAsync();
        }

        public async Task<Room?> GetRoom(int id)
        {
            return await _context.Rooms
                 .Where(c => c.IsDeleted == false)
                 .Include(r => r.RoomType)
                 .ThenInclude(r => r.AllowedCohorts)
                 .Where(s => s.IsDeleted == false)
                 .Include(r => r.RoomSlots!.Where(s => s.IsDeleted == false))
                 .ThenInclude(s => s.Bookings!.Where(c => c.IsDeleted == false))
                 .Include(r => r.RoomType!.Activities)
                 .Where(c => c.IsDeleted == false)
                 .SingleOrDefaultAsync(r => r.Id == id);
        }

        public async Task<List<Room>> GetRooms()
        {
            return await _context.Rooms
                .Where(c => c.IsDeleted == false)
                .Include(r => r.RoomType)
                .ThenInclude(r => r.AllowedCohorts)
                .Where(s => s.IsDeleted == false)
                .Include(r => r.RoomSlots!.Where(s => s.IsDeleted == false))
                .ThenInclude(s => s.Bookings!.Where(c => c.IsDeleted == false))
                .Include(r => r.RoomType!.Activities)
                .Where(c => c.IsDeleted == false)
                .ToListAsync();
        }
    }
}
