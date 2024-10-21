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
        public static ActivityResponseModel ToAcivityDTO(this Activity model)
        {
            return new ActivityResponseModel
            {        
                Id = model.Id,
                Name = model.Name,
                Code = model.Code,
                CreatedAt = model.CreatedAt,
                DeletedAt = model.DeletedAt,
                UpdatedAt = model.UpdatedAt,
                Department = model.Department?.ToDepartmentShortDTO(),
/*                RoomTypes = model.RoomTypes?.Select(c=>c.ToRoomTypeShortDTO()).ToList(),*/
            };
        }

        public static Activity ToActivityFromCreate(this CreateActivityRequestModel dto)
        {
            return new Activity
            {
                Name = dto.Name,
                Code = dto.Code,
                DepartmentId = dto.DepartmentId,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
        }
        public static ActivityShortResponseModel ToActivityShortDTO(this Activity model)
        {
            return new ActivityShortResponseModel()
            {
                Id = model.Id,
                Name = model.Name,
                Code = model.Code,
            };
        }
    }
}
