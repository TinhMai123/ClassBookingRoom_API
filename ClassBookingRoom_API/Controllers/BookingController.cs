using ClassBookingRoom_Repository.RequestModels.Booking;
using ClassBookingRoom_Repository.RequestModels.BookingModifyHistory;
using ClassBookingRoom_Repository.ResponseModels.Activity;
using ClassBookingRoom_Repository.ResponseModels.Booking;
using ClassBookingRoom_Repository.ResponseModels.BookingModifyHistory;
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
        private readonly IBookingModifyHistoryService _historyService;
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService, IBookingModifyHistoryService historyService)
        {
            _bookingService = bookingService;
            _historyService = historyService;

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<BookingResponseModel>> GetById([FromRoute] int id)
        {
            try
            {
                var result = await _bookingService.GetBooking(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            } catch (Exception ex) { return StatusCode(500, ex.Message); }

        }

        [HttpGet]
        public async Task<ActionResult<List<BookingResponseModel>>> GetAll()
        {
            try
            {
                var result = await _bookingService.GetBookings();
                return Ok(result);
            } catch (Exception ex) { return StatusCode(500, ex.Message); }

        }

        [HttpPost]
        public async Task<ActionResult<BookingResponseModel>> CreateBooking([FromBody] CreateBookingRequestModel dto)
        {
            try
            {
                var result = await _bookingService.AddBookingAsync(dto);
                if (result)
                {
                    return Ok(result);
                } else return BadRequest("Inputting Incorrectly");
            } catch (Exception ex) { return StatusCode(500, ex.Message); }

        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<BookingResponseModel>> UpdateBooking([FromRoute] int id, [FromBody] UpdateBookingRequestModel update)
        {
            try
            {
                var result = await _bookingService.UpdateBookingAsync(id, update);
                if (result)
                {
                    return Ok();
                }
                return BadRequest();
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut("{id:int}/accept")]
        public async Task<ActionResult> AcceptBooking([FromRoute] int id)
        {
            try
            {
                var result = await _bookingService.AcceptBooking(id);
                if (result)
                {
                    return Ok();
                }
                return BadRequest();
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut("{id:int}/deny")]
        public async Task<ActionResult> DenyBooking([FromRoute] int id, [FromBody] string response)
        {
            try
            {
                var result = await _bookingService.DenyBooking(id, response);
                if (result)
                {
                    return Ok();
                }
                return BadRequest();
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<BookingResponseModel>> DeleteBooking(int id)
        {
            try
            {
                var result = await _bookingService.DeleteBookingAsync(id);
                if (result)
                {
                    return Ok();
                }
                return BadRequest();
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
        [HttpPost("search")]
        public async Task<ActionResult<List<BookingResponseModel>>> SearchBookQuery([FromBody] SearchBookHistoryQuery query)
        {
            try
            {
                var (bookings, totalCount) = await _bookingService.SearchBookQuery(query);
                var totalPages = (int)Math.Ceiling((double)totalCount / query.PageSize);
                Response.Headers.Append("X-Total-Count", totalCount.ToString());
                Response.Headers.Append("X-Current-Page", query.PageNumber.ToString());
                Response.Headers.Append("X-Total-Pages", totalPages.ToString());
                return Ok(bookings);
            } catch (Exception ex) { return StatusCode(500, ex.Message); }
        }
        // HISTORY
        [HttpGet("histories/{id:int}")]
        public async Task<ActionResult<BookingModifyHistoryResponseModel>> GetByHistoryId([FromRoute] int id)
        {
            try
            {
                var activity = await _historyService.Get(id);
                if (activity == null) { return NotFound(); }
                return Ok(activity);
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
        [HttpGet("{bookingId:int}/histories")]
        public async Task<ActionResult<List<BookingModifyHistoryResponseModel>>> GetHistoriesByBookingId([FromRoute] int bookingId)
        {
            try
            {
                var list = await _historyService.GetByBookingid(bookingId);
                return Ok(list);
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        [HttpGet("histories")]
        public async Task<ActionResult<List<BookingModifyHistoryResponseModel>>> GetAllHistory()
        {
            try
            {
                var list = await _historyService.Gets();
                return Ok(list);
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        [HttpPost("histories")]
        public async Task<ActionResult> CreateHistory(CreateBookingModifyHistoryRequestModel add)
        {
            try
            {
                var result = await _historyService.AddAsync(add);
                if (result)
                {
                    return Ok();
                } else
                {
                    return BadRequest();
                }
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }


        }

        [HttpPut("histories/{id:int}")]
        public async Task<ActionResult> UpdateHistory([FromRoute] int id, [FromBody] UpdateBookingModifyHistoryRequestModel update)
        {
            try
            {
                var result = await _historyService.UpdateAsync(id, update);

                if (result)
                {
                    return Ok();
                } else
                {
                    return BadRequest();
                }
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        [HttpDelete("histories/{id:int}")]
        public async Task<ActionResult> DeleteHistory([FromRoute] int id)
        {
            try
            {
                var result = await _historyService.DeleteAsync(id);
                if (result)
                {
                    return Ok(result);
                } else
                {
                    return BadRequest();
                }
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}