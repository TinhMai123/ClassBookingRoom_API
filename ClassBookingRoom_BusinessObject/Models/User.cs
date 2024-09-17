﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Models
{
    [Table("Users")]
    public class User : BaseModels
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string ProfileImageURL {  get; set; } = string.Empty;  
        public string Status { get; set; } = string.Empty; 
        public Campus? Campus { get; set; }
        public Cohort? Cohort { get; set; }
        public ICollection<UserTeam> Team { get; set; } = [];
        public ICollection<Report> Reports { get; set; } = [];      
    }
}