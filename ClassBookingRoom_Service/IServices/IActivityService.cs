using ClassBookingRoom_Repository.RequestModels.Activity;
using ClassBookingRoom_Repository.ResponseModels.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface IActivityService
    {
        Task<bool> CreateAsync(CreateActivityRequestModel add);
        Task<bool> DeleteAsync(int id);
        Task<BookingModifyHistoryResponseModel?> GetById(int id);
        Task<List<BookingModifyHistoryResponseModel>> GetAll();
        Task<bool> UpdateAsync(int id, UpdateActivityRequestModel update);
    }
}
