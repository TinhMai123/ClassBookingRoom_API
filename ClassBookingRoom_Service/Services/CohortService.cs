using ClassBookingRoom_BusinessObject.Models;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository;
using ClassBookingRoom_Service.IServices;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Services
{

    public class CohortService : ICohortService
    {

        private readonly ICohortRepo _repo;
        private readonly BaseIRepository<Cohort> _baseRepo;
        private IConfiguration _configuration;

        public CohortService(ICohortRepo repo, BaseIRepository<Cohort> baseRepo, IConfiguration configuration)
        {
            _repo = repo;
            _baseRepo = baseRepo;
            _configuration = configuration;
        }
        public async Task<bool> AddCohortAsync(Cohort add)
        {
            return await _repo.AddCohortAsync(add);
        }

        public async Task<bool> DeleteCohortAsync(int id)
        {
            return await _repo.DeleteCohortAsync(id);
        }

        public Task<Cohort> GetCohort(int id)
        {
            return _repo.GetCohort(id);
        }

        public Task<Cohort> GetCohortByCode(string code)
        {
            return _repo.GetCohortByCode(code);
        }

        public Task<List<Cohort>> GetCohorts()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateCohortAsync(Cohort update)
        {
            return await _repo.UpdateCohortAsync(update);
        }
    }
}
