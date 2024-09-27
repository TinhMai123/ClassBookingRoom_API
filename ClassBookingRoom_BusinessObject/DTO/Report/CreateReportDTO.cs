﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.DTO.Report
{
    public class CreateReportDTO
    {
        public Guid CreatorId { get; set; }
        public int RoomId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
