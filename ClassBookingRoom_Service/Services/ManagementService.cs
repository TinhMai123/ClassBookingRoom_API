using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.ResponseModels.Management;
using ClassBookingRoom_Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Services
{
    public class ManagementService : IManagementService
    {
        private readonly IUserRepo _userRepo;
        private readonly IBookingRepo _bookRepo;
        private readonly IRoomRepo _roomRepo;
        private readonly IReportRepo _reportRepo;

        public ManagementService(IUserRepo userRepo, IBookingRepo bookRepo, IRoomRepo roomRepo, IReportRepo reportRepo)
        {
            _userRepo = userRepo;
            _bookRepo = bookRepo;
            _roomRepo = roomRepo;
            _reportRepo = reportRepo;
        }

        public async Task<DashBoardStaffResponseModel> GetDashBoardForStaff()
        {
            
            return new DashBoardStaffResponseModel { 
                totalStudent = await _userRepo.GetTotalStudent(), 
                totalRoom = await _roomRepo.GetTotalRoom(), 
                totalBooking = await _bookRepo.GetTotalBooking(), 
                totalReport = await _reportRepo.GetTotalReport()
            };
        }

        public async Task<DashBoardAdminResponseModel> GetDashBoardForAdmin()
        {
            return new DashBoardAdminResponseModel
            {
                totalStudent = await _userRepo.GetTotalStudent(),
                totalRoom = await _roomRepo.GetTotalRoom(),
                totalBooking = await _bookRepo.GetTotalBooking(),
                totalManager = await _userRepo.GetTotalManager()
            }; 
        }
    }
}
