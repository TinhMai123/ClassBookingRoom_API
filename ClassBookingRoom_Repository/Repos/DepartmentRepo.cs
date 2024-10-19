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
    public class DepartmentRepo : BaseRepository<Department>, IDepartmentRepo
    {
        public DepartmentRepo(AppDbContext context) : base(context)
        {
        }
        public async Task<Department?> GetDepartmentById(int id)
        {
            return await _context.Departments
                .Where(c => c.IsDeleted == false)
                .Include(c=>c.Activities)
                .SingleOrDefaultAsync(c=>c.Id == id);
        }
        public async Task<List<Department>> GetDepartments()
        {
            return await _context.Departments
                .Where(c => c.IsDeleted == false)
                .Include(c => c.Activities)
                .ToListAsync();
        }
    }
}
