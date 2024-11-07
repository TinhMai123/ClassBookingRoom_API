using ClassBookingRoom_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.IRepos
{
    public interface IReportRepo
    {
        Task<Report?> GetReportById(int id);
        Task<List<Report>> GetReports();
        Task<List<Report>> GetReportsByRoomId(int roomId);
        Task<int> GetTotalReport();
    }
}
