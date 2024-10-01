using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.RoomType;
using ClassBookingRoom_Repository.ResponseModels.RoomType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Mappers
{
    public static class RoomTypeMapper
    {
        public static RoomTypeResponseModel ToRoomTypeDTO(this RoomType model)
        {
            return new RoomTypeResponseModel()
            {
                Id = model.Id,
                Name = model.Name,
                CreateAt = model.CreateAt,
                DeleteAt = model.DeleteAt,
                UpdatedAt = model.UpdatedAt
            };

        }
        public static RoomType ToRoomTypeFromCreate(this CreateRoomTypeRequestModel dto)
        {
            return new RoomType()
            {
                Name = dto.Name,
                CreateAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
        }


    }
}
