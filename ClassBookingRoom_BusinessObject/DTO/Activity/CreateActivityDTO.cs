using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.DTO.Activity
{
    public class CreateActivityDTO
    {
        public string? Name { get; set; }
        public int DepartmentId { get; set; }
    }
}
