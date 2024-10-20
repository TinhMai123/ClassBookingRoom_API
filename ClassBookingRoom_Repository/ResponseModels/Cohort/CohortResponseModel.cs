using ClassBookingRoom_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.Cohort
{
    public class CohortResponseModel : BaseModel
    {
        public int Id { get; set; }
        public string CohortCode { get; set; } = string.Empty;
    }
}
