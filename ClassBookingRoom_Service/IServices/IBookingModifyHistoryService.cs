using ClassBookingRoom_Repository.RequestModels.Booking;
using ClassBookingRoom_Repository.RequestModels.BookingModifyHistory;
using ClassBookingRoom_Repository.ResponseModels.Booking;
using ClassBookingRoom_Repository.ResponseModels.BookingModifyHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface IBookingModifyHistoryService
    {
        Task<bool> AddAsync(CreateBookingModifyHistoryRequestModel add);
        Task<bool> DeleteAsync(int id);
        Task<BookingModifyHistoryResponseModel?> Get(int id);
        Task<List<BookingModifyHistoryResponseModel>> Gets();
        Task<bool> UpdateAsync(int id, UpdateBookingModifyHistoryRequestModel update);
    }
}
