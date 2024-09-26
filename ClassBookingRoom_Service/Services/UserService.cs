using ClassBookingRoom_BusinessObject.DTO.User;
using ClassBookingRoom_BusinessObject.Mappers;
using ClassBookingRoom_BusinessObject.Models;
using ClassBookingRoom_Repository;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Service.IServices;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _repo;
        private readonly IBaseRepository<User> _baseRepo;
        private IConfiguration _configuration;

        public UserService(IUserRepo repo, IBaseRepository<User> baseRepo, IConfiguration configuration)
        {
            _repo = repo;
            _baseRepo = baseRepo;
            _configuration = configuration;
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

        public async Task<GetUserTypeDTO> GetUserTypeByEmailAsync(string email)
        {
            return await _repo.GetUserTypeByEmail(email);
            
        }
        private string CreateToken(User user)
        {

            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Role, user.Role),
                new Claim(ClaimTypes.Email, user.Email),
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(60),
                signingCredentials: creds
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;

        }

        public async Task<string?> Login(LoginDTO request)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(request.Email) ||
                    string.IsNullOrWhiteSpace(request.Password))
                    throw new Exception("INVALID INPUT");
                var user = await _repo.GetUserByEmail(request.Email);
                if (user == null)
                    throw new Exception("USER IS NOT FOUND");
                if (!request.Password.Equals(user.Password))
                    throw new Exception("INVALID PASSWORD");
                var token = CreateToken(user);
                return token;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public async Task<User?> GetUserByEmailAsync(string email)
        {
            return await _repo.GetUserByEmail(email);
        }

        public async Task<List<UserDTO>> GetAllUser()
        {
            var modelList = await _baseRepo.GetAllAsync();
            return modelList.Select(x => x.ToUserDTO()).ToList();
        }

        public async Task<UserDetailDTO?> GetById(Guid id)
        {
            var user = await _baseRepo.GetByIdAsync(id);
            return user?.ToUserDetailDTO();
        }
    }
}
