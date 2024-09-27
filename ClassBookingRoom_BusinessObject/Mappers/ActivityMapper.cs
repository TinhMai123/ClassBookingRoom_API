using ClassBookingRoom_BusinessObject.DTO.Activity;
using ClassBookingRoom_BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Mappers
{
    public static class ActivityMapper
    {
        public static ActivityDTO ToAcivityDTO(this Activity model)
        {
            return new ActivityDTO
            {
                DepartmentId = model.DepartmentId,
                Id = model.Id,
                Name = model.Name,
                CreateAt = model.CreateAt,
                DeleteAt = model.DeleteAt,
                UpdatedAt = model.UpdatedAt
            };
        }
    }
}
