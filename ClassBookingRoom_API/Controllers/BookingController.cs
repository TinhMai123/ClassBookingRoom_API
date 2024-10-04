using ClassBookingRoom_Repository.RequestModels.Booking;
using ClassBookingRoom_Repository.ResponseModels.Booking;
using ClassBookingRoom_Service.IServices;
using ClassBookingRoom_Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassBookingRoom_API.Controllers
{
    [Route("api/bookings")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<BookingResponseModel>> GetById([FromRoute] int id)
        {
            var result = await _bookingService.GetBooking(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<BookingResponseModel>>> GetAll()
        {
            var result = await _bookingService.GetBookings();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<BookingResponseModel>> CreateCohort([FromBody] CreateBookingRequestModel dto)
        {
            var result = await _bookingService.AddBookingAsync(dto);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<BookingResponseModel>> UpdateCohort([FromRoute] int id, [FromBody] UpdateBookingRequestModel update)
        {
            var result = await _bookingService.UpdateBookingAsync(id, update);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<BookingResponseModel>> DeleteCohort(int id)
        {
            var result = await _bookingService.DeleteBookingAsync(id);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPost("search")]
        public async Task<ActionResult<List<BookingResponseModel>>> SearchBookQuery(SearchBookHistoryQuery query)
        {
            try
            {
                var (bookings, totalCount) = await _bookingService.SearchBookQuery(query);
                var totalPages = (int)Math.Ceiling((double)totalCount / query.PageSize);
                Response.Headers.Append("X-Total-Count", totalCount.ToString());
                Response.Headers.Append("X-Current-Page", query.PageNumber.ToString());
                Response.Headers.Append("X-Total-Pages", totalPages.ToString());
                return Ok(bookings);
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
    }
}

