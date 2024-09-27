using ClassBookingRoom_BusinessObject.DTO.RoomType;
using ClassBookingRoom_BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Mappers
{
    public static class RoomTypeMapper
    {
        public static RoomTypeDTO ToRoomTypeDTO(this RoomType model)
        {
            return new RoomTypeDTO()
            {
                Id = model.Id,
                Name = model.Name,
                DepartmentId = model.DepartmentId,
                CreateAt = model.CreateAt,
                DeleteAt = model.DeleteAt,
                UpdatedAt = model.UpdatedAt
            };

        }
        public static RoomType ToRoomTypeFromCreate(this CreateRoomTypeDTO dto)
        {
            return new RoomType()
            {
                Name = dto.Name,
                DepartmentId = dto.DepartmentId,
                CreateAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
        }


    }
}
