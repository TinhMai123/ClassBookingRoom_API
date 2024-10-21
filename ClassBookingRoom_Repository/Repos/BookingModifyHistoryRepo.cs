using ClassBookingRoom_Repository.Data;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassBookingRoom_Repository.Repos
{

    public class BookingModifyHistoryRepo : IBookingModifyHistoryRepo
    {
        private AppDbContext _context;
        public BookingModifyHistoryRepo(AppDbContext context)
        {
            _context = context;
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

        public async Task<bool> AddAsync(BookingModifyHistory entity)
        {
            try
            {
                await _context.BookingModifyHistories.AddAsync(entity);
                await _context.SaveChangesAsync();
                return true;
            } catch { return false; }

        }

        public async Task<bool> UpdateAsync(BookingModifyHistory entity)
        {
            try
            {
                _context.BookingModifyHistories.Update(entity);
                await _context.SaveChangesAsync();
                return true;
            } catch { return false; }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await GetBookingModifyHistoryById(id);
            if (entity != null)
            {
                _context.BookingModifyHistories.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
