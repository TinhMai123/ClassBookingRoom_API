using ClassBookingRoom_Repository.Data;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassBookingRoom_Repository.Repos
{

    public class BookingModifyHistoryRepo : BaseRepository<BookingModifyHistory>, IBookingModifyHistoryRepo
    {
        public BookingModifyHistoryRepo(AppDbContext context) : base(context)
        {
        }
        public async Task<BookingModifyHistory?> GetBookingModifyHistoryById(int id)
        {
            return await _context.BookingModifyHistories
                .Include(c => c.ModifiedBy)
                    .ThenInclude(c => c.Department.Name)
                .Include(c => c.ModifiedBy)
                    .ThenInclude(c => c.Cohort.CohortCode)
                .SingleOrDefaultAsync(c => c.Id == id);
        }
        public async Task<List<BookingModifyHistory>> GetBookingModifyHistories()
        {
            return await _context.BookingModifyHistories.Include(c => c.ModifiedBy).ToListAsync();
        }
    }
}
