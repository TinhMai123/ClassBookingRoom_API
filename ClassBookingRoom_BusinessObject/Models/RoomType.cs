﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Models
{
    [Table("RoomTypes")]
    public class RoomType : BaseModels
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Room> Rooms { get; set; } = [];
        public ICollection<AllowedCohorts> AllowedCohorts { get; set; } = [];
    }
}