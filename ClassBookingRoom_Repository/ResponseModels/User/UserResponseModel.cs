﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.User
{
    public class UserResponseModel
    {
        public Guid Id { get; set; }
        public string FullName {  get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string ProfileImageURL { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int? DepartmentId { get; set; }
        public int? CohortId { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
        public DateTime? DeleteAt { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
