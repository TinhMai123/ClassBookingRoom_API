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
            return await _repo.AddReportAsync(add);
        }

        public async Task<bool> DeleteReportAsync(int id)
        {
            return await _repo.DeleteReportAsync(id);
        }

        public Task<Report> GetReport(int id)
        {
            return _repo.GetReport(id);
        }

        public Task<Report> GetReportByTitle(string title)
        {
            return _repo.GetReportByTitle(title);
        }

        public Task<List<Report>> GetReports()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateReportAsync(Report update)
        {
            return await _repo.UpdateReportAsync(update);
        }
    }
}
