using ClassBookingRoom_Repository.Data;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task<Cohort?> GetCohortByCode(string code)
        {
            return await _context.Cohorts.SingleOrDefaultAsync(c => c.CohortCode.ToLower().Equals(code.ToLower()));
        }

    }
}
