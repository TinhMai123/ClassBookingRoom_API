using ClassBookingRoom_BusinessObject.DTO;
using ClassBookingRoom_BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Mappers
{
    public static class CohortMapper
    {
        public static CohortDTO ToCohortDTO(this Cohort model)
        {
            return new CohortDTO
            {
                Id = model.Id,
                CohortCode = model.CohortCode
            };
        }
    }
}
