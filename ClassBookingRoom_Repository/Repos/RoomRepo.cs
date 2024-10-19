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
            var room = await _context.Rooms
                .Where(c => c.IsDeleted == false)
                .Include(r => r.RoomType)
                .Include(r => r.RoomSlots)
                .SingleOrDefaultAsync(r => r.Id == id);

            if (room != null)
            {
                // Filter RoomType if necessary
                if (room.RoomType?.IsDeleted == true)
                {
                    room.RoomType = null; // Set to null if the RoomType is deleted
                }

                // Filter RoomSlots
                room.RoomSlots = room.RoomSlots.Where(rs => !rs.IsDeleted).ToList();
            }

            return room;
        }

        public async Task<List<Room>> GetRooms()
        {
            return await _context.Rooms
                .Where(c=>c.IsDeleted == false)
                .Include(r => r.RoomType)
                .Include(r => r.RoomSlots)
                .ToListAsync();
        }
    }
}
