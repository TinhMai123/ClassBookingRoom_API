using ClassBookingRoom_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.IRepos
{
    public interface IBookingRepo 
    {
        Task<Booking?> GetBooking(int id);
        Task<List<Booking>> GetBookings();
        Task<List<Booking>> GetRecentBookingsByRoomId(int roomId);
    }
}
