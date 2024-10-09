using ClassBookingRoom_Repository.ResponseModels.Cohort;
using ClassBookingRoom_Repository.ResponseModels.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.User
{
    public class UserDetailResponseModel
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string ProfileImageURL { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int? DepartmentId { get; set; }
        public int? CohortId { get; set; }
        public DepartmentResponseModel? Department { get; set; }
        public CohortResponseModel? Cohort { get; set; }
    }
}
