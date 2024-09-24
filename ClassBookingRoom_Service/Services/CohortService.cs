using ClassBookingRoom_BusinessObject.Models;
using ClassBookingRoom_Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Services
{
    public class CohortService : ICohortService
    {
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
