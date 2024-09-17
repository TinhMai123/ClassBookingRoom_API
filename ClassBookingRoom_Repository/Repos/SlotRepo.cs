using ClassBookingRoom_BusinessObject.Models;
using ClassBookingRoom_Repository.Data;
using ClassBookingRoom_Repository.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Repos
{
    public class SlotRepo : BaseRepository<Slot>, ISlotRepo
    {
        public SlotRepo(AppDbContext context) : base(context)
        {
        }
    }

}
