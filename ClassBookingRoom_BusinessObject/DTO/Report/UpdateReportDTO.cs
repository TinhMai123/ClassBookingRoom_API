using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.DTO.Report
{
    public class UpdateReportDTO
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string Status { get; set; } = "Pending";
    }
}
