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
        Task<bool> AddReportAsync(Report add);
        Task<bool> DeleteReportAsync(int id);
        Task<Report> GetReport(int id);
        Task<List<Report>> GetReports();
        Task<Report> GetReportByTitle(string title);
        Task<bool> UpdateReportAsync(Report update);
    }
}
