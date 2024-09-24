using ClassBookingRoom_BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface ICohortService
    {
        Task<bool> AddCohortAsync(Cohort add);
        Task<bool> DeleteCohortAsync(int id);
        Task<Cohort> GetCohort(int id);
        Task<List<Cohort>> GetCohorts();
        Task<Cohort> GetCohortByCode(string code);
        Task<bool> UpdateCohortAsync(Cohort update);
    }
}
