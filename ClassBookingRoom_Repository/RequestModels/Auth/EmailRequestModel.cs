using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.Auth
{
    public class EmailRequestModel
    {
        public string? ToUser { get; set; }
        public string? Body { get; set; }
    }
}
