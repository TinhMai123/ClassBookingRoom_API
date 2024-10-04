using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.Activity;
using ClassBookingRoom_Repository.ResponseModels.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Mappers
{
    public static class ActivityMapper
    {
        public static BookingModifyHistoryResponseModel ToAcivityDTO(this Activity model)
        {
            return new BookingModifyHistoryResponseModel
            {
                DepartmentId = model.DepartmentId,
                Id = model.Id,
                Name = model.Name,
                CreateAt = model.CreateAt,
                DeleteAt = model.DeleteAt,
                UpdatedAt = model.UpdatedAt,
            };
        }

        public static Activity ToActivityFromCreate(this CreateActivityRequestModel dto)
        {
            return new Activity
            {
                Name = dto.Name,
                DepartmentId = dto.DepartmentId,
                CreateAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
        }
    }
}
