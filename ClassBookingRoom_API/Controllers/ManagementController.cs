using ClassBookingRoom_Repository.ResponseModels.Management;
using ClassBookingRoom_Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassBookingRoom_API.Controllers
{
    [Route("management")]
    [ApiController]
    public class ManagementController : ControllerBase
    {

        private readonly IManagementService _management;

        public ManagementController(IManagementService management)
        {
            _management = management;
        }

        [HttpGet("data-staff-dashboard")]
        public async Task<ActionResult<DashBoardStaffResponseModel>> DashBoardStaff()
        {
            var total = await _management.GetDashBoardForStaff();
            return Ok(total);
        }

        [HttpGet("data-admin-dashboard")]
        public async Task<ActionResult<DashBoardAdminResponseModel>> DashBoardAdmin()
        {
            var total = await _management.GetDashBoardForAdmin();
            return Ok(total);
        }
    }
}
