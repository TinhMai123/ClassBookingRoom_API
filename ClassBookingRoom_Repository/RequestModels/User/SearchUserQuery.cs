using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.RequestModels.User
{
    public class SearchUserQuery
    {
        public string? SearchValue { get; set; } = null;
        public string? Role { get; set; } = null;
        public string? Status { get; set; } = null;
        public int? DepartmentId { get; set; }
        public int? CohortId { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
