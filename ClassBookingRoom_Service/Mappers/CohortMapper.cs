using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.Cohort;
using ClassBookingRoom_Repository.ResponseModels.Cohort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Mappers
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
                DeletedAt = model.DeletedAt,
                CreatedAt = model.CreatedAt
            };
        }
        public static Cohort ToCohortFromCreate(this CreateCohortRequestModel dto)
        {
            return new Cohort
            {
                CohortCode = dto.CohortCode,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
        }
    }
}
