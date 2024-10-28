using ClassBookingRoom_Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassBookingRoom_API.Controllers
{
    [Route("api/notifications")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;
        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpPost("notify")]
        public async Task<IActionResult> Notify()
        {
            try
            {
                var result = await _notificationService.NotifyManager();
                if (result) return Ok();
                else return StatusCode(500, "Failed");
            } catch (Exception ex) { return StatusCode(500, ex.Message); }
        }
    }
}
