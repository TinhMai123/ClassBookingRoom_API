using ClassBookingRoom_Repository.ResponseModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.Management
{
    public class DashBoardStaffResponseModel
    {
        public int totalStudent { get; set; }
        public int totalReport { get; set; }
        public int totalRoom { get; set; }
        public int totalBooking { get; set; }
        public ICollection<int> totalBookinginMonth { get; set; } = [];
        public ICollection<PercentStudentInCohort> PercentUserInCohort { get; set; } = [];
    }
}
