using ClassBookingRoom_BusinessObject.Models;
using ClassBookingRoom_Repository.Data;
using ClassBookingRoom_Repository.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Repos
{
    public class ReportRepo : BaseRepository<Report>, IReportRepo
    {
        public ReportRepo(AppDbContext context) : base(context)
        {
        }

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
