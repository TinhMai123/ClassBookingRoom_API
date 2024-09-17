using ClassBookingRoom_BusinessObject.DTO;
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

        public async Task<GetUserDTO> GetUserById(string email)
        {
            var answer =  await _context.Users.Where(c=>c.Email == email).SingleOrDefaultAsync();
            var user = new GetUserDTO
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
            return await _context.Users.Where(c => c.Equals(name)).ToListAsync();
        }

    }
}
