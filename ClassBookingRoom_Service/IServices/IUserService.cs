using ClassBookingRoom_BusinessObject.DTO;
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
        Task<GetUserDTO> GetUserByEmailAsync(string email);
    }
}
