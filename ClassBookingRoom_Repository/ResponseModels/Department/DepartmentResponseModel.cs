using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.ResponseModels.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.Department
{
    public class DepartmentResponseModel : BaseModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<ActivityResponseModel>? Activites { get; set; } = [];
    }
}
