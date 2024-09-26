using ClassBookingRoom_BusinessObject.DTO.User;
using ClassBookingRoom_BusinessObject.Models;
using ClassBookingRoom_Repository.Data;
using ClassBookingRoom_Repository.IRepos;
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

        public async Task<GetUserTypeDTO> GetUserTypeByEmail(string email)
        {
            var answer = await GetUserByEmail(email);
            var user = new GetUserTypeDTO
            {
                FirstName = answer.FirstName,
                LastName = answer.LastName,
                Email = answer.Email,
                CreatedAt = answer.CreateAt,
                Role = answer.Role,
            };
            return user;
        }

        public async Task<List<User>> GetUserByName(string name)
        {
            return await _context.Users.Where(c => c.FirstName.Equals(name) || c.LastName.Equals(name)).ToListAsync();
        }
        public async Task<User?> GetUserByEmail(string email)
        {
            return await _context.Users
                .Include(x => x.Cohort)
                .Include(x => x.Department)
                .FirstOrDefaultAsync(c => c.Email == email);
        }

        public async Task<User?> GetById(Guid id)
        {
            return await _context.Users
                .Include(x => x.Cohort)
                .Include(x => x.Department)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
