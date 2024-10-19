using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.User
{
    public class UpdateUserShortRequestModel
    {
        public int DepartmentId { get; set; }
        public int CohortId { get; set; }
    }
}
