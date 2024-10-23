using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.User
{
    public class UpdateUserStatusRequest
    {
        public string Note { get; set; } = string.Empty;
        public string Status { get; set; } = "Active";
    }
}
