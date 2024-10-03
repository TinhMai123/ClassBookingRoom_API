﻿using ClassBookingRoom_Repository.Models;
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
            var user = model.CreateBy?.ToUserDTO();
            return new BookingResponseModel
            {
                Id = model.Id,
                ActivityId = model.ActivityId,
                Description = model.Description,
                UserId = model.UserId,
                Status = model.Status,
                CreateBy = user,
                UpdatedAt = model.UpdatedAt,
                DeleteAt = model.DeleteAt,
                CreateAt = model.CreateAt
            };
        }
        public static Booking ToCohortFromCreate(this CreateBookingRequestModel dto)
        {
            return new Booking
            {
                Status = dto.Status,
                ActivityId = dto.ActivityId,
                Description = dto.Description,
                UserId = dto.UserId,
                CreateAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
        }
    }
}
