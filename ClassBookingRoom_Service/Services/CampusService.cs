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
using Microsoft.EntityFrameworkCore;

namespace ClassBookingRoom_Service.Services
{
    class CampusService : ICampusService
    {
        private readonly ICampusRepo _repo;
        private readonly IBaseRepository<Campus> _baseRepo;
        private IConfiguration _configuration;

        public CampusService(ICampusRepo repo, IBaseRepository<Campus> baseRepo, IConfiguration configuration)
        {
            _repo = repo;
            _baseRepo = baseRepo;
            _configuration = configuration;
        }
        public async Task<bool> AddCampusAsync(Campus add)
        {
           return await _baseRepo.AddAsync(add);

        }

        public async Task<bool> DeleteCampusAsync(int id)
        {
            return await _baseRepo.DeleteAsync(id);
            
        }

        public  Task<Campus> GetCampus(int id)
        {
            return  _baseRepo.GetByIdAsync(id);
        }

        public Task<Campus> GetCampusByName(string name)
        {
            return _repo.GetCampusByName(name);
        }

        public Task<List<Campus>> GetCampuses()
        {
            return _baseRepo.GetAllAsync();
        }

        public Task<bool> UpdateCampusAsync(Campus update)
        {
            return _baseRepo.UpdateAsync(update);
        }
    }
}
