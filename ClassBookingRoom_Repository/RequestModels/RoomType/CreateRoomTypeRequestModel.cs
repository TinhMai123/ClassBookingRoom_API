﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.RoomType
{
    public class CreateRoomTypeRequestModel
    {
        public int RoomTypeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CohortId { get; set; }
        public int ActivityId { get; set; }
    }
}
