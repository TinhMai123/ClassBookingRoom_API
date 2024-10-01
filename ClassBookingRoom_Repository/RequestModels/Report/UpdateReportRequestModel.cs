using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.Report
{
    public class UpdateReportRequestModel
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string Status { get; set; } = "Pending";
    }
}
