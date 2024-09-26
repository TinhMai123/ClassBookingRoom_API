using ClassBookingRoom_BusinessObject.DTO.User;
using ClassBookingRoom_BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface IUserService
    {
        Task AddUserAsync(AddUserTestDTO add);
        Task<bool> DeleteUserAsync(int id);
        Task<GetUserTypeDTO> GetUserTypeByEmailAsync(string email);
        Task<User?> GetUserByEmailAsync(string email);
        Task<string?> Login(LoginDTO request);
        Task<List<UserDTO>> GetAllUser();
        Task<UserDetailDTO?> GetById(Guid id);
    }
}
