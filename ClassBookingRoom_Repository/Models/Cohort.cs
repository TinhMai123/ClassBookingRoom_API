﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Models
{
    [Table("Cohort")]
    public class Cohort : BaseModel
    {
        public int Id { get; set; }
        public string? CohortCode { get; set; }
        public ICollection<User>? Users { get; set; }
        public ICollection<RoomType>? RoomTypes { get; set; }
    }
}
