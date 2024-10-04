﻿using ClassBookingRoom_Repository.ResponseModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.BookingModifyHistory
{
    public class CreateBookingModifyHistoryRequestModel
    {
        
        public int BookingId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid ModifiedById { get; set; }
        public string OldStatus { get; set; } = string.Empty;
        public string NewStatus { get; set; } = string.Empty;
    }
}
