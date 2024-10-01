using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.Cohort;
using ClassBookingRoom_Repository.ResponseModels.Cohort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface ICohortService
    {
        Task<bool> AddCohortAsync(CreateCohortRequestModel add);
        Task<bool> DeleteCohortAsync(int id);
        Task<CohortResponseModel?> GetCohort(int id);
        Task<List<CohortResponseModel>> GetCohorts();
        Task<bool> UpdateCohortAsync(int id,UpdateCohortRequestModel update);
    }
}
