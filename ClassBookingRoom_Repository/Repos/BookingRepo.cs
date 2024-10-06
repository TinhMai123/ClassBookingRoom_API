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
    public class BookingRepo : BaseRepository<Booking> , IBookingRepo
    {
        public BookingRepo(AppDbContext context) : base(context)
        {
        }

        public async Task<Booking?> GetBooking(int id)
        {
            return await _context.Bookings.Include(b => b.CreateBy).SingleOrDefaultAsync(b => b.Id == id);
        }

        public async Task<List<Booking>> GetBookings()
        {
            return await _context.Bookings.Include(b => b.CreateBy).ToListAsync();
        }
    }
}
