using ClassBookingRoom_BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.DTO.User
{
    public class UserDetailDTO
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string ProfileImageURL { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DepartmentDTO? Department { get; set; }
        public CohortDTO? Cohort { get; set; }
    }
}
