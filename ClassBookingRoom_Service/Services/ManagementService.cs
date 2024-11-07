using ClassBookingRoom_Repository;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.ResponseModels.Cohort;
using ClassBookingRoom_Repository.ResponseModels.Management;
using ClassBookingRoom_Repository.ResponseModels.User;
using ClassBookingRoom_Service.IServices;
using ClassBookingRoom_Service.Mappers;
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
        private readonly ICohortRepo _cohortRepo;
        private readonly IBaseRepository<Cohort> _baseCohort;

        public ManagementService(IUserRepo userRepo, IBookingRepo bookRepo, IRoomRepo roomRepo, IReportRepo reportRepo, ICohortRepo cohortRepo, IBaseRepository<Cohort> baseCohort)
        {
            _userRepo = userRepo;
            _bookRepo = bookRepo;
            _roomRepo = roomRepo;
            _reportRepo = reportRepo;
            _cohortRepo = cohortRepo;
            _baseCohort = baseCohort;
        }
        public async Task<List<PercentStudentInCohort>> GetPercentStudent()
        {
            var cohort = await _baseCohort.GetAllAsync();
            var cohortList = cohort.Select(c => c.ToCohortShortDTO()).ToList();
            List<PercentStudentInCohort> percentStudentList = [];

            foreach (CohortShortResponseModel c in cohortList ?? [])
            {
                percentStudentList.Add(new PercentStudentInCohort
                {
                    CohortCode = c.CohortCode,
                    PercentStudent =
                    ((double)await _userRepo.GetTotalStudentInCohort(c.Id) / ((double)await _userRepo.GetTotalStudent())) * 100
                });
            }
            return percentStudentList;
        }

        public async Task<List<int>> GetBookingbyMonthsStat()
        {
            var thisYear = DateTime.Now.Year;
            var bookings = await _bookRepo.GetBookings();
            var bookingbyMonthsStat = new List<int>();
            var months = new List<int>() {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
            };
            foreach (var month in months)
            {
                var numOfBookings = bookings.Where(b => b.CreatedAt.Month == month && b.CreatedAt.Year == thisYear).Count();
                bookingbyMonthsStat.Add(numOfBookings);
            }
            return bookingbyMonthsStat;
        }

        public async Task<DashBoardStaffResponseModel> GetDashBoardForStaff()
        {
            var users = await _userRepo.GetAllUser();
            var rooms = await _roomRepo.GetRooms();
            var bookings = await _bookRepo.GetBookings();
            var reports = await _reportRepo.GetReports();
            return new DashBoardStaffResponseModel
            {

                totalStudent = users.Where(u => u.Role == "Student").Count(),
                totalRoom = rooms.Count(),
                totalBooking = bookings.Count(),
                totalReport = reports.Count(),
                PercentUserInCohort = await GetPercentStudent(),
                totalBookinginMonth = await GetBookingbyMonthsStat()
            };
        }

        public async Task<DashBoardAdminResponseModel> GetDashBoardForAdmin()
        {
            var users = await _userRepo.GetAllUser();
            var rooms = await _roomRepo.GetRooms();
            var bookings = await _bookRepo.GetBookings();
            return new DashBoardAdminResponseModel
            {
                totalStudent = users.Where(u => u.Role == "Student").Count(),
                totalRoom = rooms.Count(),
                totalBooking = bookings.Count(),
                totalManager = users.Where(u => u.Role == "Manager").Count(),
                PercentStudentInCohort = await GetPercentStudent(),
                totalBookinginMonth = await GetBookingbyMonthsStat()
            };
        }
    }
}
