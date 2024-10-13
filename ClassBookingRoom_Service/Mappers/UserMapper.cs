using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.User;
using ClassBookingRoom_Repository.ResponseModels.User;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassBookingRoom_Service.Mappers
{
    public static class UserMapper
    {
        public static UserResponseModel ToUserDTO(this User model)
        {
            return new UserResponseModel
            {
                Email = model.Email,
                FullName = model.FullName,
                Id = model.Id,
                ProfileImageURL = model.ProfileImageURL,
                Role = model.Role,
                Status = model.Status,
                CohortId = model.CohortId,
                DepartmentId = model.DepartmentId,
                CreatedAt = model.CreatedAt,
                DeletedAt = model.DeletedAt,
                UpdatedAt = model.UpdatedAt,
                
            };
        }

        public static User ToUserFromCreate(this CreateUserRequestModel dto)
        {
            return new User
            {
                Email = dto.Email,
                FullName = dto.FullName,
                CohortId = dto.CohortId,
                DepartmentId = dto.DepartmentId,       
                Password = dto.Password,
                ProfileImageURL = dto.ProfileImageURL,
                Role = dto.Role,
                Status = dto.Status,
            };
        }
        public static UserDetailResponseModel ToUserDetailDTO(this User model) { 
            var cohort = model.Cohort?.ToCohortDTO();
            var department = model.Department?.ToDepartmentDTO();
            return new UserDetailResponseModel
            {
                Email = model.Email,
                Id = model.Id,
                FullName = model.FullName,
                ProfileImageURL = model.ProfileImageURL,
                Role = model.Role,
                Status = model.Status,
/*                Cohort = cohort,
                Department = department,*/
                DepartmentName = department?.Name,
                CohortCode = cohort?.CohortCode,
                DepartmentId =  model.DepartmentId,
                CohortId = model.CohortId,
                CreatedAt = model.CreatedAt,
                DeletedAt = model.DeletedAt,
                UpdatedAt = model.UpdatedAt,
            };
        }
    }
}
