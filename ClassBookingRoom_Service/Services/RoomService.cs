using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository;
using ClassBookingRoom_Service.IServices;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.Room;
using ClassBookingRoom_Service.Mappers;
using ClassBookingRoom_Repository.ResponseModels.Room;
using ClassBookingRoom_Repository.Repos;
using Microsoft.EntityFrameworkCore;
using ClassBookingRoom_Repository.ResponseModels.Booking;
using ClassBookingRoom_Repository.ResponseModels.Report;

namespace ClassBookingRoom_Service.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepo _repo;
        private readonly IReportRepo _reportRepo;
        private readonly IBookingRepo _bookRepo;
        private readonly IBaseRepository<Room> _baseRepo;
        public RoomService(IRoomRepo repo, IBaseRepository<Room> baseRepo, IReportRepo reportRepo, IBookingRepo bookRepo)
        {
            _repo = repo;
            _baseRepo = baseRepo;
            _reportRepo = reportRepo;
            _bookRepo = bookRepo;
        }
        public async Task<bool> AddRoomAsync(CreateRoomRequestModel dto)
        {
            return await _baseRepo.AddAsync(dto.ToRoomFromCreate());
        }

        public async Task<bool> DeleteRoomAsync(int id)
        {
            return await _baseRepo.DeleteAsync(id);
        }

        public async Task<List<BookingResponseModel>> GetBookingsByRoomId(int roomId)
        {
            var bookings = await _bookRepo.GetBookings();
            return bookings.Select(booking => booking.ToBookingDTO()).Where(b => b.RoomId == roomId).ToList();
        }

        public async Task<List<ReportResponseModel>> GetReportsByRoomId(int roomId)
        {
            var reports = await _reportRepo.GetReportsByRoomId(roomId);
            return reports.Select(x => x.ToReportDTO()).ToList();
        }

        public async Task<RoomResponseModel?> GetRoom(int id)
        {
            var room = await _repo.GetRoom(id);
            return room?.ToRoomDTO();
        }

        public async Task<List<RoomResponseModel>> GetRooms()
        {
            var rooms = await _repo.GetRooms();
            return rooms.Select(x => x.ToRoomDTO()).ToList(); 
        }

        public async Task<(List<RoomResponseModel> response, int totalCount)> SearchRoomQuery(SearchRoomQuery query)
        {
            var modelList = await _repo.GetRooms(); 
            var result = modelList.AsQueryable();

            if (!string.IsNullOrWhiteSpace(query.SearchValue))
            {
                result = result.Where(r => r.RoomName.Contains(query.SearchValue));
            }
            if (!string.IsNullOrWhiteSpace(query.Status))
            {
                result = result.Where(r => r.Status.Contains(query.Status));
            }
            if (!string.IsNullOrEmpty(query.ActivityCode))
            {
                result = result.Where(c => c.RoomType!.Activities.Any(c=>c.Code.Equals(query.ActivityCode)));
            }
            if (!string.IsNullOrWhiteSpace(query.CohortCode))
            {
                result = result.Where(r => r.RoomType!.AllowedCohorts.Any(c=>c.CohortCode!.Equals(query.CohortCode)));
            }
            if (query.RoomTypeId is not null)
            {
                result = result.Where(r => r.RoomTypeId == query.RoomTypeId);
            }
            if (query.MinCapacity is not null)
            {
                result = result.Where(r => r.Capacity >= query.MinCapacity);
            }
            if (query.MaxCapacity is not null)
            {
                result = result.Where(r => r.Capacity <= query.MaxCapacity);
            }
            if (query.StartTime is not null)
            {
                result = result.Where(r => r.RoomSlots!.Any(c => c.StartTime.CompareTo(query.StartTime) <= 0));
            }
            if (query.EndTime is not null)
            {
                result = result.Where(r => r.RoomSlots!.Any(c => c.EndTime.CompareTo(query.EndTime) >= 0));
            }
            if (query.BookingDate is not null)
            {
                result = result.Where(r => r.RoomSlots!.Any(c => c.Bookings!
                .Any(c => c.BookingDate.CompareTo(query.BookingDate) == 0)));
            }
            
/*            result = result.Where(r=>r.RoomSlots!.Any(c=>c.Bookings!.Any(c => c.Status.ToUpper().Equals("CANCEL") || c.Status == null || c.Status.ToUpper().Equals("DENIED")))
                || r.RoomSlots!.All(c => c.Bookings == null));*/
            var totalCount = result.Count(); 
            var skipNumber = (query.PageNumber > 0 ? query.PageNumber - 1 : 0) * (query.PageSize > 0 ? query.PageSize : 10);
            var paginatedResult = result
                .Skip(skipNumber)
                .Take(query.PageSize)
                .ToList(); 
            return (paginatedResult.Select(x => x.ToRoomDTO()).ToList(), totalCount);
        }     
        public async Task<bool> UpdateRoomAsync(int id, UpdateRoomRequestModel update)
        {
            var room = await _baseRepo.GetByIdAsync(id);
            if (room is null) { return false; }
            room.UpdatedAt = DateTime.UtcNow;
            room.Status = update.Status ?? "";
            room.Capacity = update.Capacity;
            room.RoomTypeId = update.RoomTypeId;
            room.RoomName = update.RoomName;
            room.Picture = update.Picture;
            return await _baseRepo.UpdateAsync(room); 
        }

        
    }
}
