using ClassBookingRoom_BusinessObject;
using ClassBookingRoom_BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.IRepos
{
    public interface IRoomTypeRepo
    {
        Task<RoomType> GetRoomTypeByName(string name);
    }
}
