using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.Department
{
    public class UpdateDepartmentRequestModel
    {
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
