using ClassBookingRoom_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.IRepos
{
    public interface IBookingModifyHistoryRepo
    {
        Task<BookingModifyHistory?> GetBookingModifyHistoryById(int id);
        Task<List<BookingModifyHistory>> GetBookingModifyHistories();
    }
}
