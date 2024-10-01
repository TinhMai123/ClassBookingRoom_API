using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.Activity
{
    public class UpdateActivityRequestModel
    {
        public string? Name { get; set; }
        public int DepartmentId { get; set; }
    }
}
