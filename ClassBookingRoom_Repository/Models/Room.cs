﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Models
{
    [Table("Room")]
    public class Room : BaseModel
    {
        public int Id { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public int Capacity { get; set; } = 0;
        public string Status { get; set; } = string.Empty;
        public string Picture { get; set; } = string.Empty;
        public int? RoomTypeId { get; set; }
        public RoomType? RoomType { get; set; }
        public ICollection<Report>? Reports { get; set; }
        public ICollection<RoomSlot>? RoomSlots { get; set; }

    }
}
