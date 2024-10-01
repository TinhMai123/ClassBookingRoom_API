using ClassBookingRoom_BusinessObject.DTO.User;
using ClassBookingRoom_BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassBookingRoom_BusinessObject.Mappers
{
    public static class UserMapper
    {
        public static UserDTO ToUserDTO(this User model)
        {
            return new UserDTO
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
            };
        }

        public static User ToUserFromCreate(this CreateUserDTO dto)
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
        public static UserDetailDTO ToUserDetailDTO(this User model) { 
            var cohort = model.Cohort?.ToCohortDTO();
            var department = model.Department?.ToDepartmentDTO();
            return new UserDetailDTO
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
