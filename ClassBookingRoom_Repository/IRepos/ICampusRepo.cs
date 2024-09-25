using ClassBookingRoom_BusinessObject.DTO.User;
using ClassBookingRoom_BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.IRepos
{
    public interface ICampusRepo
    {
        Task<Campus> GetCampusByName(string name);
    }
}
