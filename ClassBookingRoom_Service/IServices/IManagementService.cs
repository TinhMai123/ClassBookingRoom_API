using ClassBookingRoom_Repository.ResponseModels.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface IManagementService
    {
        Task<DashBoardStaffResponseModel> GetDashBoardForStaff();
        Task<DashBoardAdminResponseModel> GetDashBoardForAdmin();


    }
}
