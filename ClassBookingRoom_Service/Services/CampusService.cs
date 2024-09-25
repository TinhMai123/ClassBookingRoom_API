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
        private readonly BaseIRepository<Campus> _baseRepo;
        private IConfiguration _configuration;

        public CampusService(ICampusRepo repo, BaseIRepository<Campus> baseRepo, IConfiguration configuration)
        {
            _repo = repo;
            _baseRepo = baseRepo;
            _configuration = configuration;
        }
        public async Task<bool> AddCampusAsync(Campus add)
        {
           return await _repo.AddCampusAsync(add); 

        }

        public async Task<bool> DeleteCampusAsync(int id)
        {
            var de = await _baseRepo.DeleteAsync(id);
            return de;
        }

        public  Task<Campus> GetCampus(int id)
        {
            return  _repo.GetCampus(id);
        }

        public Task<Campus> GetCampusByName(string name)
        {
            return _repo.GetCampusByName(name);
        }

        public Task<List<Campus>> GetCampuses()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCampusAsync(Campus update)
        {
            return _repo.UpdateCampusAsync(update);
        }
    }
}
