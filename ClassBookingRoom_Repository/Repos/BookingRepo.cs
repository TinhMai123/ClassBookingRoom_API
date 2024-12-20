﻿using ClassBookingRoom_Repository.Data;
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
    public class BookingRepo : BaseRepository<Booking>, IBookingRepo
    {
        public BookingRepo(AppDbContext context) : base(context)
        {
        }

        public async Task<Booking?> GetBooking(int id)
        {
            return await _context.Bookings
                .Where(c => c.IsDeleted == false)
                .Include(b => b.CreateBy)
                .Include(b => b.CreateBy.Department)
                .Include(b => b.CreateBy.Cohort)
                .Include(b => b.RoomSlots)
                .ThenInclude(s => s.Room)
                .Include(b => b.Activity)
                .SingleOrDefaultAsync(b => b.Id == id);
        }

        public async Task<List<Booking>> GetBookings()
        {
            return await _context.Bookings
                .Where(c => c.IsDeleted == false)
                .Include(b => b.CreateBy)
                .Include(b => b.CreateBy.Department)
                .Include(b => b.CreateBy.Cohort)
                .Include(b => b.RoomSlots)
                .ThenInclude(s => s.Room)
                .Include(b => b.Activity)
                .ToListAsync();
        }

        public async Task<List<Booking>> GetRecentBookingsByRoomId(int roomId)
        {
            return await _context.Bookings
               .Where(c => c.IsDeleted == false
               && c.BookingDate.Date == DateTime.Today.Date)
               .Include(b => b.CreateBy)
               .Include(b => b.CreateBy.Department)
               .Include(b => b.CreateBy.FaceDescriptor)
               .Include(b => b.CreateBy.Cohort)
               .Include(b => b.RoomSlots)
               .ThenInclude(s => s.Room)
               .Where(b => b.RoomSlots.First().Room.Id == roomId)
               .Include(b => b.Activity)
               .ToListAsync();
        }

        public async Task<int> GetTotalBooking()
        {
            return await _context.Bookings
               .Where(c => c.IsDeleted == false)
               .CountAsync();
        }
    }
}
