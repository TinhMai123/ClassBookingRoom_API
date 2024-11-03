using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.ResponseModels.Activity;
using ClassBookingRoom_Repository.ResponseModels.Cohort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.ResponseModels.RoomType
{
    public class RoomTypeResponseModel : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<ActivityShortResponseModel> AllowedActivities { get; set; } = [];
        public ICollection<CohortShortResponseModel> AllowedCohorts { get; set; } = [];
    }
}
