using ClassBookingRoom_BusinessObject.Models;
using ClassBookingRoom_Repository.Data;
using ClassBookingRoom_Repository.IRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Repos
{
    public class RoomTypeRepo : BaseRepository<RoomType>, IRoomTypeRepo
    {
        private readonly DbContext _context;
        public RoomTypeRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }
        

        public async Task<bool> AddRoomTypeAsync(RoomType add)
        {
            _context.Set<RoomType>().Add(add);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteRoomTypeAsync(int id)
        {
            var roomType = await _context.Set<RoomType>().FindAsync(id);
            if (roomType != null)
            {
                _context.Set<RoomType>().Remove(roomType);
                return await _context.SaveChangesAsync() > 0;
            }
            return false;
        }

        public Task<RoomType> GetRoomTypeByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<RoomType> GetRoomType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<RoomType>> GetRoomTypes()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRoomTypeAsync(RoomType update)
        {
            throw new NotImplementedException();
        }
    }
}
