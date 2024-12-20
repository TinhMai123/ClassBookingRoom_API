﻿using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.ResponseModels.Activity;
using ClassBookingRoom_Repository.ResponseModels.Booking;
using ClassBookingRoom_Repository.ResponseModels.Cohort;
using ClassBookingRoom_Repository.ResponseModels.RoomSlot;
using ClassBookingRoom_Repository.ResponseModels.RoomType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.Room
{
    public class RoomResponseModel : BaseModel
    {
        public int Id { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public int Capacity { get; set; } = 0;
        public string? Status { get; set; }
        public string Picture { get; set; } = string.Empty;
        public int? RoomTypeId { get; set; }
        public RoomTypeResponseModel? RoomType { get; set; }
        public ICollection<SlotsForRoomResponseModel> RoomSlots { get; set; } = [];
        public int NumOfPendingBooking { get; set; } = 0;
    }
}
