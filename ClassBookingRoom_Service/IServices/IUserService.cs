using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.Auth;
using ClassBookingRoom_Repository.RequestModels.User;
using ClassBookingRoom_Repository.ResponseModels.User;
using FirebaseAdmin.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface IUserService
    {
        Task<bool> AddUserAsync(CreateUserRequestModel dto);
        Task<bool> DeleteUserAsync(Guid id);
        Task<GetUserTypeResponseModel?> GetUserTypeByEmailAsync(string email);
        Task<User?> GetUserByEmailAsync(string email);
        Task<UserResponseModel?> GetUserDetailByEmailAsync(string email);
        Task<string?> LoginGoogle(FirebaseToken token, string role);
        Task<string?> Login(LoginRequestModel request);
        Task<List<UserResponseModel>> GetAllUser();
        Task<(List<UserResponseModel>, int)> SearchUser(SearchUserQuery query);
        Task<UserResponseModel?> GetById(Guid id);
        Task<bool> UpdateUser(Guid id, UpdateUserRequestModel dto);
        Task<bool> UpdateUser(Guid id, UpdateUserShortRequestModel dto);
        Task<bool> UpdateUser(Guid id, string Status);
        Task<bool> UpdateUserAsync(User user);
        Task<bool> VerifyUser(Guid id, string verifyToken);
        Task<bool> UpdateVerifyToken(Guid id, string verifyToken);
        Task<bool> UpdatePushToken(Guid id, string pushToken);
        Task<bool> UpdateUserStatus(Guid id, UpdateUserStatusRequest request);

    }
}
