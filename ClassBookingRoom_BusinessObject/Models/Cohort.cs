using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Models
{
    public class Cohort : BaseModels
    {
        public int Id { get; set; }
        public string? CohortCode { get; set; }
        public ICollection<User>? Users { get; set; }
        public ICollection<AllowedCohorts>? AllowedCohorts { get; set; }
    }
}
