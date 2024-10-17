using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.Department;
using ClassBookingRoom_Repository.ResponseModels.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Mappers
{
    public static class DepartmentMapper
    {
        public static DepartmentResponseModel ToDepartmentDTO(this Department model)
        {
            return new DepartmentResponseModel()
            {
                Id = model.Id,
                Name = model.Name,
                Activites = model.Activities?.Select(c => c.ToAcivityDTO()).ToList(),
                CreatedAt = model.CreatedAt,
                DeletedAt = model.DeletedAt,
                UpdatedAt = model.UpdatedAt,
            };
        }
        public static Department ToDepartmentFromCreate(this CreateDepartmentRequestModel dto)
        {
            return new Department
            {
                Name = dto.Name,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
        }
    }
}
