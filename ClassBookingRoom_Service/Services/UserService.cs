﻿using ClassBookingRoom_Repository;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.Auth;
using ClassBookingRoom_Repository.RequestModels.User;
using ClassBookingRoom_Repository.ResponseModels.User;
using ClassBookingRoom_Service.IServices;
using ClassBookingRoom_Service.Mappers;
using FirebaseAdmin.Auth;
using Microsoft.EntityFrameworkCore;
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
        private readonly IBaseRepository<Cohort> _cohortRepo;
        private readonly IBaseRepository<Department> _departmentRepo;

        private IConfiguration _configuration;

        public UserService(IUserRepo repo, IBaseRepository<User> baseRepo, IConfiguration configuration, IBaseRepository<Cohort> cohortRepo, IBaseRepository<Department> departmentRepo)
        {
            _repo = repo;
            _baseRepo = baseRepo;
            _configuration = configuration;
            _cohortRepo = cohortRepo;
            _departmentRepo = departmentRepo;
        }
        public async Task<bool> AddUserAsync(CreateUserRequestModel dto)
        {
            var user = dto.ToUserFromCreate();
            return await _baseRepo.AddAsync(user);
        }
        public async Task<bool> DeleteUserAsync(Guid id)
        {
            var deleted = await _repo.DeleteUser(id);
            return deleted;
        }

        public async Task<GetUserTypeResponseModel?> GetUserTypeByEmailAsync(string email)
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
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: creds
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }
        public async Task<string?> Login(LoginRequestModel request)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(request.Email) ||
                    string.IsNullOrWhiteSpace(request.Password))
                    throw new Exception("Invalid input");
                var user = await _repo.GetUserByEmail(request.Email);
                if (user == null)
                    throw new Exception("User is not found");
                if (!request.Password.Equals(user.Password))
                    throw new Exception("Invalid password");
                var token = CreateToken(user);
                return token;
            } catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }
        public async Task<string?> LoginGoogle(FirebaseToken firebaseToken, string role)
        {
            var claims = firebaseToken.Claims;
            try
            {
                var email = claims.GetValueOrDefault("email");
                if (email!=null)
                {
                    var user = await _repo.GetUserByEmail(email.ToString()!);
                    if (user == null)
                    {
                        string fullName = claims.GetValueOrDefault("name")!.ToString()!;
                        string[] nameParts = fullName.Split(' ');
/*                        if (nameParts.Length >= 2)
                        {
                            firstName = nameParts[0];
                            lastName = nameParts[1];
                        }*/
                        var newUser = new User
                        {
                            FullName = fullName,
                            ProfileImageURL = claims.GetValueOrDefault("picture")!.ToString()!,
                            Email = claims.GetValueOrDefault("email")!.ToString()!,
                            Password = claims.GetValueOrDefault("user_id")!.ToString()!,
                            Role = role,
                            Status = "Unverified"
                        };
                        var result = await _baseRepo.AddAsync(newUser);
                        var loginRequest = new LoginRequestModel()
                        {
                            Email = newUser.Email,
                            Password = newUser.Password
                        };
                        var login = await Login(loginRequest);
                        return login;
                    } else
                    {
                        if (user.Role != role)
                        {
                            throw new Exception("Invalid role");
                        }
                        var token = CreateToken(user);
                        return token;
                    }
                } else
                {
                    throw new Exception("Invalid firebase token");
                }
            } catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }
        public async Task<UserDetailResponseModel?> GetUserByEmailAsync(string email)
        {
            var user = await _repo.GetUserByEmail(email);
            return user?.ToUserDetailDTO();
        }

        public async Task<List<UserResponseModel>> GetAllUser()
        {
            var modelList = await _baseRepo.GetAllAsync();
            return modelList.Select(x => x.ToUserDTO()).ToList();
        }

        public async Task<UserDetailResponseModel?> GetById(Guid id)
        {
            var user = await _repo.GetById(id);
            return user?.ToUserDetailDTO();
        }

        public async Task<bool> UpdateUser(Guid id, UpdateUserRequestModel dto)
        {
            var existingUser = await _baseRepo.GetByIdAsync(id);
            if (existingUser == null) return false;
            existingUser.FullName = dto.FullName;
            existingUser.Role = dto.Role;
            existingUser.ProfileImageURL = dto.ProfileImageURL;
            existingUser.Status = dto.Status;
            var cohort = await _cohortRepo.GetByIdAsync(dto.CohortId);
            var department = await _departmentRepo.GetByIdAsync(dto.DepartmentId);
            //if (campus == null || cohort == null || department == null) return false;
            existingUser.Cohort = cohort;
            existingUser.Department = department;
            existingUser.UpdatedAt = DateTime.UtcNow;
            return await _baseRepo.UpdateAsync(existingUser);
        }

        public async Task<(List<UserResponseModel>, int)> SearchUser(SearchUserQuery query)
        {
            var modelList = await _baseRepo.GetAllAsync();
            var result = modelList.AsQueryable();
            if (!string.IsNullOrWhiteSpace(query.SearchValue))
            {
                result = result.Where(c => c.FullName.Contains(query.SearchValue));
            }
            if (!string.IsNullOrWhiteSpace(query.Status))
            {
                result = result.Where(c => c.Status.Contains(query.Status));
            }
            if (!string.IsNullOrWhiteSpace(query.Role))
            {
                result = result.Where(c => c.Role.Contains(query.Role));
            }
            if (query.DepartmentId is not null)
            {
                result = result.Where(c => c.DepartmentId == query.DepartmentId);
            }
            if (query.CohortId is not null)
            {
                result = result.Where(c => c.CohortId == query.CohortId);
            }
            var totalCount = result.Count();
            var skipNumber = (query.PageNumber - 1) * query.PageSize;
            var classResult = result.Skip(skipNumber).Take(query.PageSize).ToList();
            return (classResult.Select(x => x.ToUserDTO()).ToList(), totalCount);
        }
    }
}
