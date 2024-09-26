using ClassBookingRoom_BusinessObject.DTO;
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
                Name = model.Name
            };
        }
    }
}
