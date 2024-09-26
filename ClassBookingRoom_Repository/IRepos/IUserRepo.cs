using ClassBookingRoom_BusinessObject;
using ClassBookingRoom_BusinessObject.DTO.User;
using ClassBookingRoom_BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.IRepos
{
    public interface IUserRepo
    {
        Task<GetUserTypeDTO> GetUserTypeByEmail(string email);
        Task<User?> GetUserByEmail(string email);
        Task<User?> GetById(Guid id);
        Task<List<User>> GetUserByName(string name);
    }
}
