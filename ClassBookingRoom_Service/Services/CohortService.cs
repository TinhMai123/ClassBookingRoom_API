using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository;
using ClassBookingRoom_Service.IServices;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.ResponseModels.Cohort;
using ClassBookingRoom_Repository.RequestModels.Cohort;
using ClassBookingRoom_Service.Mappers;

namespace ClassBookingRoom_Service.Services
{

    public class CohortService : ICohortService
    {

        private readonly ICohortRepo _repo;
        private readonly IBaseRepository<Cohort> _baseRepo;

        public CohortService(ICohortRepo repo, IBaseRepository<Cohort> baseRepo)
        {
            _repo = repo;
            _baseRepo = baseRepo;
        }
        public async Task<bool> AddCohortAsync(CreateCohortRequestModel add)
        {
            return await _baseRepo.AddAsync(add.ToCohortFromCreate());
        }

        public async Task<bool> DeleteCohortAsync(int id)
        {
            return await _baseRepo.DeleteAsync(id);
        }

        public async Task<CohortResponseModel?> GetCohort(int id)
        {
            var result = await _baseRepo.GetByIdAsync(id);
            return result?.ToCohortDTO();
        }

        public async Task<List<CohortResponseModel>> GetCohorts()
        {
            var result = await _baseRepo.GetAllAsync();
            return result.Select(x => x.ToCohortDTO()).ToList();
        }

        public async Task<bool> UpdateCohortAsync(int id, UpdateCohortRequestModel update)
        {
            var result = await _baseRepo.GetByIdAsync(id);
            if (result is null){return false;}
            result.UpdatedAt = DateTime.Now;
            result.CohortCode = update.CohortCode;
            return await _baseRepo.UpdateAsync(result);
        }
    }
}
