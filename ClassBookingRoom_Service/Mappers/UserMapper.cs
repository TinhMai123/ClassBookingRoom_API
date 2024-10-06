using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.User;
using ClassBookingRoom_Repository.ResponseModels.User;
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
                FirstName = model.FirstName,
                Id = model.Id,
                LastName = model.LastName,
                ProfileImageURL = model.ProfileImageURL,
                Role = model.Role,
                Status = model.Status,
                CohortId = model.CohortId,
                DepartmentId = model.DepartmentId,
                CreateAt = model.CreateAt,
                DeleteAt = model.DeleteAt,
                UpdatedAt = model.UpdatedAt
            };
        }

        public static User ToUserFromCreate(this CreateUserRequestModel dto)
        {
            return new User
            {
                Email = dto.Email,
                FirstName = dto.FirstName,
                CohortId = dto.CohortId,
                DepartmentId = dto.DepartmentId,
                LastName = dto.LastName,
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
                FirstName = model.FirstName,
                Id = model.Id,
                LastName = model.LastName,
                ProfileImageURL = model.ProfileImageURL,
                Role = model.Role,
                Status = model.Status,
                Cohort = cohort,
                Department = department,
                DepartmentId =  model.DepartmentId,
                CohortId = model.CohortId
            };
        }
    }
}
