using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Models
{
    [Table("User")]
    public class User : BaseModel
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string ProfileImageURL { get; set; } = string.Empty;
        public string Status { get; set; } = "Active";
        public int? DepartmentId { get; set; }
        public int? CohortId { get; set; }
        public string? Note { get; set; }
        public string? VerifyToken { get; set; }
        public bool IsVerify { get; set; } = false;
        public FaceDescriptor? FaceDescriptor { get; set; }
        public Department? Department { get; set; }
        public Cohort? Cohort { get; set; }
        public ICollection<Report> Reports { get; set; } = [];
        public ICollection<Booking> Bookings { get; set; } = [];
        public ICollection<BookingModifyHistory> BookingModifyHistories { get; set; } = [];
    }
}
