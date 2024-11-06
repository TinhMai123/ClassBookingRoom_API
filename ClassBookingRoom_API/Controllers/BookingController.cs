using ClassBookingRoom_Repository.RequestModels.Booking;
using ClassBookingRoom_Repository.RequestModels.BookingModifyHistory;
using ClassBookingRoom_Repository.ResponseModels.Activity;
using ClassBookingRoom_Repository.ResponseModels.Booking;
using ClassBookingRoom_Repository.ResponseModels.BookingModifyHistory;
using ClassBookingRoom_Service.IServices;
using ClassBookingRoom_Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace ClassBookingRoom_API.Controllers
{
    [Route("api/bookings")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingModifyHistoryService _historyService;
        private readonly IBookingService _bookingService;
        private readonly IUserService _userService;

        public BookingController(IBookingService bookingService, IBookingModifyHistoryService historyService, IUserService userService)
        {
            _bookingService = bookingService;
            _historyService = historyService;
            _userService = userService;
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
                    return Ok("Booking accepted successfully");
                }
                return BadRequest();
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id:int}/check-in")]
        public async Task<ActionResult> CheckInBooking([FromRoute] int id)
        {
            try
            {
                var result = await _bookingService.CheckInBooking(id);
                if (result)
                {
                    return Ok("Booking accepted successfully");
                }
                return BadRequest();
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id:int}/cancel")]
        public async Task<ActionResult> CancelBooking([FromRoute] int id)
        {
            Request.Headers.TryGetValue("Authorization", out var token);
            token = token.ToString().Split()[1];
            if (string.IsNullOrWhiteSpace(token))
            {
                return BadRequest("Authorization header is missing or invalid.");
            }
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            if (jwtToken.ValidTo < DateTime.UtcNow)
            {
                return BadRequest("Token has expired.");
            }
            string? email = jwtToken.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress")?.Value;
            if (email is null)
            {
                return StatusCode(401);
            }
            var user = await _userService.GetUserDetailByEmailAsync(email);
            if (user == null)
            {
                return BadRequest("email is in valid");
            }

            try
            {
                var booking = await _bookingService.GetBooking(id);
                if (booking == null)
                {
                    return BadRequest("Booking not found");
                }
                if (booking.StudentId != user.Id)
                {
                    return BadRequest("Only owner can cancel this booking");
                }
                var result = await _bookingService.CancelBooking(id);
                if (result)
                {
                    return Ok("Booking cancelled successfully");
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
                    return Ok("Booking denied successfully");
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
        [HttpGet("total-bookings")]
        public async Task<ActionResult<int>> GetTotalBooking()
        {
            int total = await _bookingService.GetTotalBooking();
            return Ok(total);
        }
    }
}