using ClassBookingRoom_Repository;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.Repos;
using ClassBookingRoom_Repository.RequestModels.Booking;
using ClassBookingRoom_Repository.RequestModels.Cohort;
using ClassBookingRoom_Repository.ResponseModels.Booking;
using ClassBookingRoom_Repository.ResponseModels.Cohort;
using ClassBookingRoom_Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ClassBookingRoom_Service.Mappers
{
    public static class BookingMapper
    {
        public static BookingResponseModel ToBookingDTO(this Booking model)
        {
            var slots = model.RoomSlots?.Select(c => c.ToRoomSlotShortResponseDTO()).ToList();
            var room = model.RoomSlots.First().Room;
            return new BookingResponseModel
            {
                Id = model.Id,
                ActivityId = model.ActivityId,
                Description = model.Description,
                StudentId = model.UserId,
                Status = model.Status,
                UpdatedAt = model.UpdatedAt,
                DeletedAt = model.DeletedAt,
                CreatedAt = model.CreatedAt,
                StudentFullName = model.CreateBy?.FullName ?? "",
                StudentEmail = model.CreateBy?.Email ?? "",
                CohortCode = model.CreateBy?.Cohort?.CohortCode ?? "",
                ActivityCode = model.Activity?.Code ?? "",
                ActivityName = model.Activity?.Name ?? "",
                DepartmentId = model.CreateBy?.DepartmentId,
                DepartmentName = model.CreateBy?.Department?.Name ?? "",
                RoomSlots = slots,
                RoomId = room.Id,
                RoomName = room.RoomName,
                Code = model.Code,
            };
        }
        public static async Task<Booking> ToBookingFromCreate(this CreateBookingRequestModel dto, IRoomSlotRepo roomSlotRepo)
        {
            var slots = await roomSlotRepo.GetRoomSlotsByIdsAsync(dto.RoomSlots);
            return new Booking
            {
                Code = CodeGeneratetor.GenerateBookingCode(),
                Status = dto.Status,
                ActivityId = dto.ActivityId,
                Description = dto.Description,
                RoomSlots = slots,
                UserId = dto.UserId,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
        }
        public static async Task<Booking> ToBookingFromUpdate(this UpdateBookingRequestModel dto, int id, IRoomSlotRepo roomSlotRepo)
        {
            return new Booking
            {
                Id = id,
                Description = dto.Description,
                Status = dto.Status,
                ActivityId = dto.ActivityId,
                UserId = dto.UserId,
                UpdatedAt = DateTime.UtcNow,
                RoomSlots = await roomSlotRepo.GetRoomSlotsByIdsAsync(dto.RoomSlots),
            };
        }
    }
}
