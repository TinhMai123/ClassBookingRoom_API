using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository;
using ClassBookingRoom_Repository.RequestModels.Booking;
using ClassBookingRoom_Repository.ResponseModels.Booking;
using ClassBookingRoom_Service.IServices;
using ClassBookingRoom_Service.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepo _repo;
        private readonly IBaseRepository<Booking> _baseRepo;

        public BookingService(IBookingRepo repo, IBaseRepository<Booking> baseRepo)
        {
            _repo = repo;
            _baseRepo = baseRepo;
        }
        public async Task<bool> AddBookingAsync(CreateBookingRequestModel add)
        {
            var result = await _baseRepo.AddAsync(add.ToCohortFromCreate());
            return result;
        }

        public async Task<bool> DeleteBookingAsync(int id)
        {
            return await _baseRepo.DeleteAsync(id);
        }

        public async Task<BookingResponseModel?> GetBooking(int id)
        {
            var result = await _baseRepo.GetByIdAsync(id);
            return result?.ToBookingDTO();
        }

        public async Task<List<BookingResponseModel>> GetBookings()
        {
            var result = await _baseRepo.GetAllAsync();
            return result.Select(x => x.ToBookingDTO()).ToList();
        }

        public async Task<bool> UpdateBookingAsync(int id, UpdateBookingRequestModel update)
        {
            var result = await _baseRepo.GetByIdAsync(id);
            if (result is null)
            {
                return false;
            }
            result.Description = update.Description;
            result.Status = update.Status;
            result.ActivityId = update.ActivityId;
            result.UserId = update.UserId;
            result.UpdatedAt = DateTime.Now;
            return await _baseRepo.UpdateAsync(result);
        }
    }
}
