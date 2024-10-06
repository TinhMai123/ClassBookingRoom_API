using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository;
using ClassBookingRoom_Repository.RequestModels.BookingModifyHistory;
using ClassBookingRoom_Repository.ResponseModels.BookingModifyHistory;
using ClassBookingRoom_Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Service.Mappers;

namespace ClassBookingRoom_Service.Services
{
    public class BookingModifyHistoryService : IBookingModifyHistoryService
    {
        private readonly IBaseRepository<BookingModifyHistory> _baseRepo;

        public BookingModifyHistoryService(IBaseRepository<BookingModifyHistory> baseRepo)
        {
            _baseRepo = baseRepo;
        }
        public async Task<bool> AddAsync(CreateBookingModifyHistoryRequestModel add)
        {
            return await _baseRepo.AddAsync(add.ToBookingModifyHistoryFromCreate());
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _baseRepo.DeleteAsync(id);
        }

        public async Task<BookingModifyHistoryResponseModel?> Get(int id)
        {
            var result = await _baseRepo.GetByIdAsync(id);
            return result?.ToBookingModifyHistoryDTO();
        }

        public async Task<List<BookingModifyHistoryResponseModel>> GetByBookingid(int bookingId)
        {
            var result = await _baseRepo.GetAllAsync();
            result = result.Where(x => x.BookingId == bookingId).ToList();
            return result.Select(x => x.ToBookingModifyHistoryDTO()).ToList();
        }

        public async Task<List<BookingModifyHistoryResponseModel>> Gets()
        {
            var result = await _baseRepo.GetAllAsync();
            return result.Select(x => x.ToBookingModifyHistoryDTO()).ToList();
        }

        public async Task<bool> UpdateAsync(int id, UpdateBookingModifyHistoryRequestModel update)
        {
            var result = await _baseRepo.GetByIdAsync(id);
            if (result is null) { return false; }
            result.UpdatedAt = DateTime.Now;
            result.ModifiedDate = DateTime.Now;
            result.NewStatus = update.NewStatus;
            result.OldStatus = update.OldStatus;
            result.BookingId = update.BookingId;
            return await _baseRepo.UpdateAsync(result);
        }
    }
}
