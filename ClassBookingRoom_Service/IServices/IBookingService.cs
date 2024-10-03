using ClassBookingRoom_Repository.RequestModels.Booking;
using ClassBookingRoom_Repository.RequestModels.Cohort;
using ClassBookingRoom_Repository.ResponseModels.Booking;
using ClassBookingRoom_Repository.ResponseModels.Cohort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface IBookingService
    {
        Task<bool> AddBookingAsync(CreateBookingRequestModel add);
        Task<bool> DeleteBookingAsync(int id);
        Task<BookingResponseModel?> GetBooking(int id);
        Task<List<BookingResponseModel>> GetBookings();
        Task<bool> UpdateBookingAsync(int id, UpdateBookingRequestModel update);
    }
}
