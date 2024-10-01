using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.User
{
    public class UpdateUserRequestModel
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string ProfileImageURL { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int DepartmentId { get; set; }
        public int CohortId { get; set; }
    }
}
