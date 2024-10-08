using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.Auth
{
    public class LoginGoogleRequest
    {
        public required string AccessToken { get; set; }
        public required string Role { get; set; }
    }
}
