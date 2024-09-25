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
    public class CohortRepo : BaseRepository<Cohort> , ICohortRepo
    {
        public CohortRepo(AppDbContext context) : base(context)
        {
        }

        public Task<bool> AddCohortAsync(Cohort add)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCohortAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Cohort> GetCohort(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Cohort> GetCohortByCode(string code)
        {
            throw new NotImplementedException();
        }

        public Task<List<Cohort>> GetCohorts()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCohortAsync(Cohort update)
        {
            throw new NotImplementedException();
        }
    }
}
