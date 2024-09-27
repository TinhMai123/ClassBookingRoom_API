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
using ClassBookingRoom_BusinessObject.DTO.Report;
using ClassBookingRoom_BusinessObject.Mappers;

namespace ClassBookingRoom_Service.Services
{

    public class ReportService : IReportService
    {
        private readonly IBaseRepository<Report> _baseRepo;
        private IConfiguration _configuration;

        public ReportService(IBaseRepository<Report> baseRepo, IConfiguration configuration)
        {
            _baseRepo = baseRepo;
            _configuration = configuration;
        }
        public async Task<bool> AddAsync(CreateReportDTO add)
        {
            return await _baseRepo.AddAsync(add.CreateReportFromDTO());
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _baseRepo.DeleteAsync(id);
        }

        public async Task<ReportDTO?> GetById(int id)
        {
            var result = await _baseRepo.GetByIdAsync(id);
            return result?.ToReportDTO();
        }

        public async Task<List<ReportDTO>> GetAll()
        {
            var list = await _baseRepo.GetAllAsync();
            return list.Select(x => x.ToReportDTO()).ToList();
        }

        public async Task<bool> UpdateAsync(int id, UpdateReportDTO update)
        {
            var result = await _baseRepo.GetByIdAsync(id);
            if (result is null) { return false; }
            result.Title = update.Title;
            result.Description = update.Description;
            result.UpdatedAt = DateTime.Now;
            return await _baseRepo.UpdateAsync(result);
        }
    }

}

