using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.Room;
using ClassBookingRoom_Repository.ResponseModels.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Mappers
{
    public static class RoomMapper
    {
        public static RoomResponseModel ToRoomDTO(this Room model)
        {
            return new RoomResponseModel()
            {
                Id = model.Id,
                Capacity = model.Capacity,
                RoomName = model.RoomName,
                RoomTypeId = model.RoomTypeId,
                Status = model.Status,
                CreateAt = model.CreateAt,
                DeleteAt = model.DeleteAt,
                UpdatedAt = model.UpdatedAt
            };
        }

        public static Room ToRoomFromCreate(this CreateRoomRequestModel dto)
        {
            return new Room()
            {
                Capacity = dto.Capacity,
                RoomName = dto.RoomName,
                RoomTypeId = dto.RoomTypeId,
                Status = dto.Status,
                CreateAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
        }
        public static SearchRoomResponseModel ToRoomSearch(this Room dto)
        {
            return new SearchRoomResponseModel()
            {
                Id = dto.Id,
                Capacity = dto.Capacity,
                RoomName = model.RoomName,
                RoomTypeId = model.RoomTypeId,
                Status = model.Status,
                CreateAt = model.CreateAt,
                DeleteAt = model.DeleteAt,
                UpdatedAt = model.UpdatedAt
            }
        }
    }
}
