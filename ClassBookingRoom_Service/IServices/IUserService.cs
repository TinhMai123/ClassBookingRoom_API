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
        Task<bool> DeleteUserAsync(int id);
        Task<GetUserTypeResponseModel?> GetUserTypeByEmailAsync(string email);
        Task<UserDetailResponseModel?> GetUserByEmailAsync(string email);
        Task<string?> LoginGoogle(FirebaseToken token, string role);
        Task<string?> Login(LoginRequestModel request);
        Task<List<UserResponseModel>> GetAllUser();
        Task<(List<UserResponseModel>, int)> SearchUser(SearchUserQuery query);
        Task<UserDetailResponseModel?> GetById(Guid id);
        Task<bool> UpdateUser(Guid id, UpdateUserRequestModel dto);
    }
}
