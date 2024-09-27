using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.DTO.Department
{
    public class UpdateDepartmentDTO
    {
        [Required]
        public string Name { get; set; } = String.Empty;
    }
}
