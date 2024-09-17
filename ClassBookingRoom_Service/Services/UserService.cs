using ClassBookingRoom_BusinessObject.DTO;
using ClassBookingRoom_BusinessObject.Models;
using ClassBookingRoom_Repository;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _repo;
        private readonly BaseIRepository<User> _baseRepo;

        public UserService(IUserRepo repo, BaseIRepository<User> baseRepo)
        {
            _repo = repo;
            _baseRepo = baseRepo;
        }
        public async Task AddUserAsync(AddUserTestDTO add) {
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = add.FirstName,
                LastName = add.LastName,
                Email = add.Email,
                Password = add.Password,
            };
            
            await _baseRepo.AddAsync(user);
        }
        public async Task<bool> DeleteUserAsync(int id)
        {
            var deleted = await _baseRepo.DeleteAsync(id);
            return deleted;
        }

        public async Task<GetUserDTO> GetUserByEmailAsync(string email)
        {
            var user = await _repo.GetUserById(email);
            return user;
        }
    }
}
