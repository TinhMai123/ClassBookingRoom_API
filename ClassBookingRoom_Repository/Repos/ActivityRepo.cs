using ClassBookingRoom_Repository.Data;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Repos
{
    public class ActivityRepo : BaseRepository<Activity>, IActivityRepo
    {
        public ActivityRepo(AppDbContext context) : base(context)
        {
        }
        public async Task<Activity?> GetActivityById(int id)
        {
            return await _context.Activities
                .Include(c=>c.Department)
                .Include(c=>c.RoomTypes)
                .SingleOrDefaultAsync(c=>c.Id==id);
        }
        public async Task<List<Activity>> GetActivities()
        {
            return await _context.Activities
               .Include(c => c.Department)
               .Include(c => c.RoomTypes).ToListAsync();
        }
    }
}
