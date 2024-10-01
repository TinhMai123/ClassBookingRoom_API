using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.Auth
{
    public class LoginRequestModel
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
