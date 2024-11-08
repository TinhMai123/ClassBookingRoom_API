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
using Microsoft.EntityFrameworkCore;

namespace ClassBookingRoom_Service.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepo _repo;
        private readonly IBaseRepository<Booking> _baseRepo;
        private readonly IRoomSlotRepo _roomSlotRepo;
        private readonly INotificationService _notificationService;
        private readonly IUserRepo _userRepo;
        private readonly IRoomRepo _roomRepo;
        private readonly IBaseRepository<RoomSlot> _baseSlotRepo;

        public BookingService(IBookingRepo repo,
                IBaseRepository<Booking> baseRepo,
                IRoomSlotRepo roomSlotRepo,
                INotificationService notificationService,
                IUserRepo userRepo,
                IRoomRepo roomRepo,
                IBaseRepository<RoomSlot> baseSlotRepo
            )
        {
            _repo = repo;
            _baseRepo = baseRepo;
            _roomSlotRepo = roomSlotRepo;
            _notificationService = notificationService;
            _userRepo = userRepo;
            _roomRepo = roomRepo;
            _baseSlotRepo = baseSlotRepo;
        }
        public async Task<bool> AddBookingAsync(CreateBookingRequestModel add)
        {
            var result = await _baseRepo.AddAsync(await add.ToBookingFromCreate(_roomSlotRepo));
            if (result)
            {
                var student = await _userRepo.GetById(add.UserId);
                var roomSlot = await _baseSlotRepo.GetByIdAsync(add.RoomSlots.First());
                var room = await _roomRepo.GetRoom(roomSlot!.RoomId);
                if (student != null)
                {
                    await _notificationService.NotifyManager("A student has successfully booked a room.", $"Student Name: {student.FullName}\r\nRoom: {room.RoomName}\r");
                }
            }
            return result;
        }


        public async Task<bool> DeleteBookingAsync(int id)
        {
            return await _baseRepo.DeleteAsync(id);
        }

        public async Task<BookingResponseModel?> GetBooking(int id)
        {
            var result = await _repo.GetBooking(id);
            return result?.ToBookingDTO();
        }

        public async Task<List<BookingResponseModel>> GetBookings()
        {
            var result = await _repo.GetBookings();
            return result.Select(x => x.ToBookingDTO()).ToList();
        }
        public async Task<List<BookingResponseModel>> GetBookingsByUserId(Guid userId)
        {
            var result = await _repo.GetBookings();
            return result.Where(b => b.CreateBy.Id == userId).Select(x => x.ToBookingDTO()).ToList();
        }
        public async Task<bool> UpdateBookingAsync(int id, UpdateBookingRequestModel update)
        {
            /*            var result = await _baseRepo.GetByIdAsync(id);
                        if (result is null)
                        {
                            return false;
                        }*/

            return await _baseRepo.UpdateAsync(await update.ToBookingFromUpdate(id, _roomSlotRepo));
        }
        public async Task<(List<BookingResponseModel>, int totalCount)> SearchBookQuery(SearchBookHistoryQuery query)
        {
            var modelRepo = await _repo.GetBookings();
            var result = modelRepo.AsQueryable();
            if (query.StartTime is not null)
            {
                result = result.Where(r => r.CreatedAt.CompareTo(query.StartTime) <= 0);
            }
            if (query.EndTime is not null)
            {
                result = result.Where(r => r.CreatedAt.CompareTo(query.StartTime) >= 0);
            }
            var totalCount = await result.CountAsync();
            var skipNumber = (query.PageNumber > 0 ? query.PageNumber - 1 : 0) * (query.PageSize > 0 ? query.PageSize : 10);
            var paginatedResult = await result.Skip(skipNumber).Take(query.PageSize).ToListAsync();
            return (paginatedResult.Select(x => x.ToBookingDTO()).ToList(), totalCount);
        }

        public async Task<bool> AcceptBooking(int id)
        {
            var booking = await _baseRepo.GetByIdAsync(id);
            if (booking == null)
            {
                throw new Exception("Booking not found");
            }
            booking.Status = "Accepted";
            booking.UpdatedAt = DateTime.UtcNow;
            return await _baseRepo.UpdateAsync(booking);
        }

        public async Task<bool> CancelBooking(int id)
        {
            var booking = await _baseRepo.GetByIdAsync(id);
            if (booking == null)
            {
                throw new Exception("Booking not found");
            }
            booking.Status = "Cancelled";
            booking.UpdatedAt = DateTime.UtcNow;
            return await _baseRepo.UpdateAsync(booking);
        }

        public async Task<bool> DenyBooking(int id, string response)
        {
            var booking = await _baseRepo.GetByIdAsync(id);
            if (booking == null)
            {
                throw new Exception("Booking not found");
            }
            booking.Status = "Denied";
            booking.Response = response;
            booking.UpdatedAt = DateTime.UtcNow;
            return await _baseRepo.UpdateAsync(booking);
        }

        public async Task<List<BookingDetailResponse>> GetRecentBookingsByRoomId(int roomId)
        {
            var result = await _repo.GetRecentBookingsByRoomId(roomId);
            return result.Select(x => x.ToBookingDetailResponse()).ToList();
        }

        public async Task<bool> CheckInBooking(int id)
        {
            var booking = await _repo.GetBooking(id);
            if (booking == null)
            {
                throw new Exception("Booking not found");
            }
            booking.Status = "Checked-in";
            booking.UpdatedAt = DateTime.UtcNow;
            var result = await _baseRepo.UpdateAsync(booking);
            if (result)
            {
                var student = await _userRepo.GetById(booking.UserId);
                var roomSlot = await _baseSlotRepo.GetByIdAsync(booking.RoomSlots.First().Id);
                var room = await _roomRepo.GetRoom(roomSlot!.RoomId);
                if (student != null)
                {
                    await _notificationService.NotifyManager("A student has successfully checked in a booking.", $"Student Name: {student.FullName}\r\nRoom: {room.RoomName}\r");
                }
            }
            return result;
        }

        public async Task<int> GetTotalBooking()
        {
            var total = await _repo.GetTotalBooking();
            return total;
        }
    }
}
