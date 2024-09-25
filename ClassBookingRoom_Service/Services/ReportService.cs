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

    public class ReportService : IReportService
    {
        private readonly IReportRepo _repo;
        private readonly BaseIRepository<Report> _baseRepo;
        private IConfiguration _configuration;

        public ReportService(IReportRepo repo, BaseIRepository<Report> baseRepo, IConfiguration configuration)
        {
            _repo = repo;
            _baseRepo = baseRepo;
            _configuration = configuration;
        }
        public async Task<bool> AddReportAsync(Report add)
        {
            return await _baseRepo.AddAsync(add);
        }

        public async Task<bool> DeleteReportAsync(int id)
        {
            return await _baseRepo.DeleteAsync(id);
        }

        public Task<Report> GetReport(int id)
        {
            return _baseRepo.GetByIdAsync(id);
        }

        public Task<Report> GetReportByTitle(string title)
        {
            return _repo.GetReportByTitle(title);
        }

        public Task<List<Report>> GetReports()
        {
            return  _baseRepo.GetAllAsync();
        }

        public async Task<bool> UpdateReportAsync(Report update)
        {
            return await _baseRepo.UpdateAsync(update);
        }
    }
}
