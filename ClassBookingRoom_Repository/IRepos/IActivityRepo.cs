using ClassBookingRoom_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.IRepos
{
    public interface IActivityRepo
    {
        Task<Activity?> GetActivityById(int id);
        Task<List<Activity>> GetActivities();
        Task<List<Activity>> GetActivitiesByDepartmentId(int departmentId);
        Task<Activity?> GetActivityByCode(string code);
    }
}
