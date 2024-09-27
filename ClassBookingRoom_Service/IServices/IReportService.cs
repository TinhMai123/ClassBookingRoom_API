using ClassBookingRoom_BusinessObject.DTO.Activity;
using ClassBookingRoom_BusinessObject.DTO.Report;
using ClassBookingRoom_BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface IReportService
    {
        Task<bool> AddAsync(CreateReportDTO add);
        Task<bool> DeleteAsync(int id);
        Task<ReportDTO?> GetById(int id);
        Task<List<ReportDTO>> GetAll();
        Task<bool> UpdateAsync(int id,UpdateReportDTO update);
    }
}
