using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.DTO.User
{
    public class UserAuthDTO
    {
        public string? email { get; set; }
        public string? Token { get; set; }
        public int Time { get; set; }
    }
}
