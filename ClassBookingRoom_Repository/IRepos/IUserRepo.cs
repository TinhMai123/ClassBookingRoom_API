using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.ResponseModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.IRepos
{
    public interface IUserRepo
    {
        Task<GetUserTypeResponseModel?> GetUserTypeByEmail(string email);
        Task<User?> GetUserByEmail(string email);
        Task<User?> GetById(Guid id);
        Task<List<User>> GetAllUser();
        Task<List<User>> GetUserByName(string name);
        Task<bool> DeleteUser(Guid id);
        Task<int> TotalStudent();
    }
}
