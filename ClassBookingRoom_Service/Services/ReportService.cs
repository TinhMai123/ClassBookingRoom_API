using ClassBookingRoom_BusinessObject.Models;
using ClassBookingRoom_Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Services
{
    public class ReportService : IReportService
    {
        public Task<bool> AddReportAsync(Report add)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteReportAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Report> GetReport(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Report> GetReportByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public Task<List<Report>> GetReports()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateReportAsync(Report update)
        {
            throw new NotImplementedException();
        }
    }
}
