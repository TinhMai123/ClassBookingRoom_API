using ClassBookingRoom_Repository.Data;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.ResponseModels.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Repos
{
    public class UserRepo : BaseRepository<User>, IUserRepo
    {
        public UserRepo(AppDbContext context) : base(context)
        {
        }

        public async Task<GetUserTypeResponseModel?> GetUserTypeByEmail(string email)
        {
            var answer = await GetUserByEmail(email);
            var user = new GetUserTypeResponseModel
            {
                FullName = answer.FullName,
                Email = answer.Email,
                CreatedAt = answer.CreatedAt,
                Role = answer.Role,
            };
            return user;
        }

        public async Task<List<User>> GetUserByName(string name)
        {
            return await _context.Users.Where(c => c.FullName.Contains(name) && c.IsDeleted == false).ToListAsync();
        }
        public async Task<User?> GetUserByEmail(string email)
        {
           return await _context.Users
                .Where(c=>c.IsDeleted == false)
                .Include(x => x.Cohort)
                .Include(x => x.Department)
                .FirstOrDefaultAsync(c => c.Email == email);
        }

        public async Task<User?> GetById(Guid id)
        {
            return await _context.Users
                .Where(c => c.IsDeleted == false)
                .Include(x => x.Cohort)
                .Include(x => x.Department)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> DeleteUser(Guid id)
        {
            var entity = await GetById(id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedAt = DateTime.Now;
                _context.Update(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<User>> GetAllUser()
        {
            return await _context.Users
                .Where(c => c.IsDeleted == false)
                .Include(x => x.Cohort)
                .Include(x => x.Department)
                .ToListAsync();
        }

        

        public async Task<int> TotalStudent()
        {
            return await _context.Users
                .Where(c => c.IsDeleted == false && c.Role.ToLower()
                .Equals("student"))
                .CountAsync();
        }
    }
}
