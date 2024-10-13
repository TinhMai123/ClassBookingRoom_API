using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.Booking;
using ClassBookingRoom_Repository.RequestModels.Cohort;
using ClassBookingRoom_Repository.ResponseModels.Booking;
using ClassBookingRoom_Repository.ResponseModels.Cohort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Mappers
{
    public static class BookingMapper
    {

        public static BookingResponseModel ToBookingDTO(this Booking model)
        {
            var room = model.RoomSlots?.Select(c=>c.ToRoomSlotDTO()).ToList();
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
                RoomSlots = room,
            };
        }
        public static Booking ToBookingFromCreate(this CreateBookingRequestModel dto)
        {
            return new Booking
            {
                Status = dto.Status,
                ActivityId = dto.ActivityId,
                Description = dto.Description,
                UserId = dto.UserId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
        }
    }
}
