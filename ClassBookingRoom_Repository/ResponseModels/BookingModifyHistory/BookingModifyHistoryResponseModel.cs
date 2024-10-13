using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.ResponseModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.BookingModifyHistory
{
    public class BookingModifyHistoryResponseModel : BaseModel
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid ModifiedById { get; set; }
        public UserResponseModel? ModifiedBy { get; set; }
        public string OldStatus { get; set; } = string.Empty;
        public string NewStatus { get; set; } = string.Empty;
    }
}
