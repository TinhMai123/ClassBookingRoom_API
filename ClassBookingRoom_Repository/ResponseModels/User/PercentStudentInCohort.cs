using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.User
{
    public class PercentStudentInCohort
    {
        public string CohortCode { get; set; } = string.Empty;
        public double PercentStudent {  get; set; } = 0;
    }
}
