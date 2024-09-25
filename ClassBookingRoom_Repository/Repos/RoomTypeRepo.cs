using ClassBookingRoom_BusinessObject.Models;
using ClassBookingRoom_Repository.Data;
using ClassBookingRoom_Repository.IRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Repos
{
    public class RoomTypeRepo : BaseRepository<RoomType>, IRoomTypeRepo
    {
        public RoomTypeRepo(AppDbContext context) : base(context)
        {
        }
        

        public Task<RoomType> GetRoomTypeByName(string name)
        {
            throw new NotImplementedException();
        }

    }
}
