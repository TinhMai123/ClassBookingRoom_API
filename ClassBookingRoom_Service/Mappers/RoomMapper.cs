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
            var slots = model.RoomSlots?.Select(c=>c.ToRoomSlotsFromRoomDTO()).ToList();
            return new RoomResponseModel()
            {
                Id = model.Id,
                Capacity = model.Capacity,
                RoomName = model.RoomName,
                RoomTypeId = model.RoomTypeId,
                RoomTypeName = model.RoomType?.Name ?? "",
                RoomSlots = slots ?? [],
                Status = model.Status,
                CreatedAt = model.CreatedAt,
                DeletedAt = model.DeletedAt,
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
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
        }
    }
}
