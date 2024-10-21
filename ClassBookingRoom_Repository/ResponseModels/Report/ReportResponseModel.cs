using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.ResponseModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.Report
{
    public class ReportResponseModel : BaseModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int RoomId { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public Guid StudentId { get; set; }
        public string StudentFullName { get; set; } = string.Empty;
        public string StudentEmail { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending";
    }
}
