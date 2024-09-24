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
        private readonly IReportRepo _repo;
        private readonly BaseIRepository<Campus> _baseRepo;
        private IConfiguration _configuration;

        public CampusService(IReportRepo repo, BaseIRepository<Campus> baseRepo, IConfiguration configuration)
        {
            _repo = repo;
            _baseRepo = baseRepo;
            _configuration = configuration;
        }
        public async Task<bool> AddCampusAsync(Campus add)
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
