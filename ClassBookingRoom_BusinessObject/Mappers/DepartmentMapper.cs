using ClassBookingRoom_BusinessObject.DTO.Department;
using ClassBookingRoom_BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Mappers
{
    public static class DepartmentMapper
    {
        public static DepartmentDTO ToDepartmentDTO(this Department model)
        {
            return new DepartmentDTO()
            {
                Id = model.Id,
                Name = model.Name,
                CreateAt = model.CreateAt,
                DeleteAt = model.DeleteAt,
                UpdatedAt = model.UpdatedAt,
            };
        }
        public static Department ToDepartmentFromCreate(this CreateDepartmentDTO dto)
        {
            return new Department
            {
                Name = dto.Name,
            };
        }
    }
}
