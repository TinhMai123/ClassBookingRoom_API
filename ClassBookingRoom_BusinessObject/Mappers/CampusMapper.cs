using ClassBookingRoom_BusinessObject.DTO;
using ClassBookingRoom_BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Mappers
{
    public static class CampusMapper
    {
        public static CampusDTO ToCampusDTO(this Campus model)
        {
            return new CampusDTO
            {
                Id = model.Id,
                Address = model.Address,
                HotLine = model.HotLine,
                Name = model.Name
            };
        }
    }
}
