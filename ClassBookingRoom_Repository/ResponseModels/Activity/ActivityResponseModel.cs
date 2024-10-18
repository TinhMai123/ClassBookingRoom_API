using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.ResponseModels.Department;
using ClassBookingRoom_Repository.ResponseModels.RoomType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.Activity
{
    public class ActivityResponseModel : BaseModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DepartmentShortResponseModel? Department { get; set; }
        public ICollection<RoomTypeShortResponseModel>? RoomTypes { get; set; } = [];
    }
}
