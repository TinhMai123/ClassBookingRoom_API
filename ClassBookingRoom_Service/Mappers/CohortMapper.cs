using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.ResponseModels.Cohort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Mappers
{
    public static class CohortMapper
    {
        public static CohortResponseModel ToCohortDTO(this Cohort model)
        {
            return new CohortResponseModel
            {
                Id = model.Id,
                CohortCode = model.CohortCode,
                UpdatedAt = model.UpdatedAt,
                DeleteAt = model.DeleteAt,
                CreateAt = model.CreateAt
            };
        }
    }
}
