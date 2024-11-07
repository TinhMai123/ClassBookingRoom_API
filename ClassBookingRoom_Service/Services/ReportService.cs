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
using ClassBookingRoom_Repository.RequestModels.Report;
using ClassBookingRoom_Repository.ResponseModels.Report;
using ClassBookingRoom_Service.Mappers;
using Azure;

namespace ClassBookingRoom_Service.Services
{

    public class ReportService : IReportService
    {
        private readonly IReportRepo _reportRepo;
        private readonly IBaseRepository<Report> _baseRepo;

        public ReportService(IBaseRepository<Report> baseRepo, IReportRepo reportRepo)
        {
            _baseRepo = baseRepo;
            _reportRepo = reportRepo;
        }
        public async Task<bool> AddAsync(CreateReportRequestModel dto)
        {
            return await _baseRepo.AddAsync(dto.CreateReportFromDTO());
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _baseRepo.DeleteAsync(id);
        }

        public async Task<ReportResponseModel?> GetById(int id)
        {
            var result = await _reportRepo.GetReportById(id);
            return result?.ToReportDTO();
        }

        public async Task<List<ReportResponseModel>> GetAll()
        {
            var list = await _reportRepo.GetReports();
            return list.Select(x => x.ToReportDTO()).ToList();
        }

        public async Task<bool> UpdateAsync(int id, UpdateReportRequestModel update)
        {
            var result = await _baseRepo.GetByIdAsync(id);
            if (result is null) { return false; }
            result.Status = update.Status;
            result.UpdatedAt = DateTime.UtcNow;
            return await _baseRepo.UpdateAsync(result);
        }

        public async Task<bool> AcceptReport(int id)
        {
            var report = await _baseRepo.GetByIdAsync(id);
            if (report == null)
            {
                throw new Exception("Report not found");
            }
            report.Status = "Accepted";
            report.UpdatedAt = DateTime.UtcNow;
            return await _baseRepo.UpdateAsync(report);
        }

        public async Task<bool> DenyReport(int id, string response)
        {
            var report = await _baseRepo.GetByIdAsync(id);
            if (report == null)
            {
                throw new Exception("Report not found");
            }
            report.Status = "Denied";
            report.Response = response;
            report.UpdatedAt = DateTime.UtcNow;
            return await _baseRepo.UpdateAsync(report);
        }

        public async Task<IEnumerable<ReportResponseModel>> GetReportsByUserId(Guid userId)
        {
            var list = await _reportRepo.GetReports();
            return list.Where(x => x.CreatorId == userId).Select(x => x.ToReportDTO()).ToList();
        }

        public async Task<int> GetTotalReport()
        {
            var total = await _reportRepo.GetTotalReport();
            return total;
        }
    }

}

