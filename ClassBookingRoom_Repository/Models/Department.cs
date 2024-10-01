using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Models
{
    [Table("Department")]
    public class Department : BaseModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Activity>? Activities { get; set; }
    }
}
