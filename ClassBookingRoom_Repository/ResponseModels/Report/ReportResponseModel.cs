﻿using ClassBookingRoom_Repository.ResponseModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.Report
{
    public class ReportResponseModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int RoomId { get; set; }
        public Guid CreatorId { get; set; }
        public string Status { get; set; } = "Pending";
        public UserResponseModel? CreatedBy { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime? DeleteAt { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}