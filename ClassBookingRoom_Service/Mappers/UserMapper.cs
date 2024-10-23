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
                IsVerify = model.IsVerify,
                IsDeleted = model.IsDeleted,
                CohortCode = model.Cohort?.CohortCode ?? "",
                DepartmentName = model.Department?.Name ?? "",
                Note = model.Note,
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
                IsVerify = false,
            };
        }

        public static UserShortResponseModel ToUserShortDTO(this User model)
        {
            return new UserShortResponseModel
            {
                FullName = model.FullName,
                Role = model.Role,
                DepartmentName = model.Department?.Name ?? "",
                CohortCode = model.Cohort?.CohortCode ?? "",
            };
        }
    }
}
