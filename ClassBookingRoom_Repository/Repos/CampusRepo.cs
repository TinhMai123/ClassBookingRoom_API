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
    public class CampusRepo : BaseRepository<Campus>, ICampusRepo
    {
        public CampusRepo(AppDbContext context) : base(context)
        {
        }

        public Task<bool> AddCampusAsync(Campus add)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCampusAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Campus> GetCampus(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Campus> GetCampusByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Campus>> GetCampuses()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCampusAsync(Campus update)
        {
            throw new NotImplementedException();
        }
    }
}
