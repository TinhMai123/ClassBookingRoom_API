using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Models
{
    [Table("AllowedCohort")]
    public class AllowedCohort
    {
        public int Id { get; set; }
        public RoomType? RoomType { get; set; }
        public Cohort? Cohort { get; set; }
        public bool Status { get; set; }
    }
}
