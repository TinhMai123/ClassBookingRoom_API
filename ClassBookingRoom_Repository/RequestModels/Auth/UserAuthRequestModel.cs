using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.Auth
{
    public class UserAuthRequestModel
    {
        public string? email { get; set; }
        public string? Token { get; set; }
        public int Time { get; set; }
    }
}
