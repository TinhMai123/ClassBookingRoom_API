using ClassBookingRoom_Repository.ResponseModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.Management
{
    public class DashBoardAdminResponseModel
    {
        public int totalStudent { get; set; }
        public int totalManager { get; set; }
        public int totalRoom { get; set; }
        public int totalBooking { get; set; }
        public ICollection<int> totalBookinginMonth { get; set; } = [];
        public ICollection<PercentStudentInCohort> PercentStudentInCohort { get; set; } = [];

    }
}
