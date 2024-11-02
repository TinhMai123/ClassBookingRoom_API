using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.ResponseModels.FaceDescriptor;
using ClassBookingRoom_Repository.ResponseModels.RoomSlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.Booking
{
    public class BookingDetailResponse : BaseModel
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public Guid StudentId { get; set; }
        public string? CohortCode { get; set; }
        public string StudentFullName { get; set; } = string.Empty;
        public string StudentEmail { get; set; } = string.Empty;
        public int ActivityId { get; set; }
        public string ActivityCode { get; set; } = string.Empty;
        public string ActivityName { get; set; } = string.Empty;
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? Response { get; set; }
        public int RoomId { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public DateTime BookingDate { get; set; } = DateTime.Now;
        public ICollection<RoomSlotShortResponseModel>? RoomSlots { get; set; }
        public FaceDescriptorShortResponse? FaceDescriptor { get; set; }
    }
}
