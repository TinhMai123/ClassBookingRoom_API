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
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
        private static DateTime getRelativeTime(DateTime date, DateTime time)
        {
            int difference = (int)(date - time).TotalDays;
            time.AddDays(difference);
            return time;
        }

        public async Task<List<RoomResponseModel>> GetAvailableRooms(GetAvailableRoomsRequest request)
        {
            var rooms = await _repo.GetAvailableRooms();
            var roomDTOs = new List<RoomResponseModel>();
            var bookingStartTime = getRelativeTime(request.BookingDate, request.StartTime);
            var bookingEndTime = getRelativeTime(request.BookingDate, request.EndTime);
            foreach (var room in rooms)
            {
                if (room.RoomType.AllowedCohorts.Any(c => c.Id == request.CohortId)
                    && room.RoomType.Activities.Any(a => a.Id == request.ActivityId))
                {
                    var bookings = await _bookRepo.GetBookings();
                    bookings = bookings.Where(b => b.RoomSlots.First().RoomId == room.Id
                    && b.BookingDate.Date == request.BookingDate.Date).ToList();
                    if (bookings.Count == 0)
                    {
                        roomDTOs.Add(room.ToRoomDTO());
                    } else
                    {
                        var slots = room.RoomSlots;
                        foreach (var booking in bookings)
                        {
                            if (booking.Status == "Accepted" || booking.Status == "Checked-in")
                            {
                                foreach (var slot in slots)
                                {
                                    var slotStartTime = getRelativeTime(request.BookingDate, slot.StartTime);
                                    var slotEndTime = getRelativeTime(request.BookingDate, slot.EndTime);
                                    if (slotStartTime < bookingStartTime || slotEndTime > bookingEndTime)
                                    {
                                        slots.Remove(slot);
                                    }
                                }
                            }
                        }
                        if (slots.Count > 0)
                        {
                            roomDTOs.Add(room.ToRoomDTO(slots.Select(s => s.ToRoomSlotsFromRoomDTO()).ToList()));
                        }
                    }
                }
            }
            return roomDTOs;
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
        public async Task<(List<RoomResponseModel> response, int totalCount)> SearchRoomUser(SearchRoomQuery query)
        {
            var modelList = await _repo.GetRooms();
            var result = modelList.AsQueryable();
            result = result.Where(r => r.RoomSlots!.Count() > 0);
            return SearchRoomQuery(query, result);
        }
        public async Task<(List<RoomResponseModel> response, int totalCount)> SearchRoomAdmin(SearchRoomQuery query)
        {
            var modelList = await _repo.GetRooms();
            var result = modelList.AsQueryable();
            return SearchRoomQuery(query, result);
        }
        public (List<RoomResponseModel> response, int totalCount) SearchRoomQuery(SearchRoomQuery query, IQueryable<Room> result)
        {
            if (!string.IsNullOrWhiteSpace(query.SearchValue))
            {
                result = result.Where(r => r.RoomName.Contains(query.SearchValue));
            }
            if (!string.IsNullOrWhiteSpace(query.Status))
            {
                result = result.Where(r => r.Status.Contains(query.Status));
            }
            if (query.ActivityId is not null)
            {
                result = result.Where(c => c.RoomType!.Activities.Any(c => c.Id == query.ActivityId));
            }
            if (query.CohortId is not null)
            {
                result = result.Where(r => r.RoomType!.AllowedCohorts.Any(c => c.Id == query.CohortId));
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
            /*            if (query.StartTime is not null)
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
                        }*/
            if (query.BookingDate is not null && (query.StartTime is not null || query.EndTime is not null))
            {
                result = result.Where(r =>
                    r.RoomSlots == null || r.RoomSlots.Count == 0 || r.RoomSlots.Any(slot =>
                        slot.EndTime <= query.EndTime &&
                        slot.StartTime >= query.StartTime &&
                        (
                            slot.Bookings == null || !slot.Bookings.Any() ||
                            slot.Bookings.All(c =>
                                c.BookingDate != query.BookingDate ||
                                (c.BookingDate == query.BookingDate &&
                                 (c.Status != "Accepted" && c.Status != "Checked-in")
                                )
                            )
                        )
                    )
                );
            }
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
