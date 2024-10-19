using ClassBookingRoom_Repository.Data;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Repos
{
    public class ReportRepo:  IReportRepo
    {
        private readonly AppDbContext _context;
        public ReportRepo(AppDbContext context) 
        {
            _context = context;
        }

        public async Task<Report?> GetReportById(int id)
        {
            return await _context.Reports
                .Where(c => c.IsDeleted == false)
                .Include(x => x.CreatedBy)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Report>> GetReports()
        {
            return await _context.Reports
                .Where(c => c.IsDeleted == false)
                .Include(x => x.CreatedBy).ToListAsync();
        }
    }
}
