using ClassBookingRoom_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.RoomType
{
    public class RoomTypeResponseModel : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
