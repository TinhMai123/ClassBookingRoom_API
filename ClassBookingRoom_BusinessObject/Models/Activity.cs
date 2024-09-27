using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Models
{
    [Table("Activity")]
    public class Activity : BaseModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }  
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
