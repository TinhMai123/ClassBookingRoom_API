using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.RoomSlot;
using ClassBookingRoom_Repository.ResponseModels.RoomSlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Mappers
{
    public static class RoomSlotMapper
    {
        public static RoomSlotResponseModel ToRoomSlotDTO(this RoomSlot model)
        {
            return new RoomSlotResponseModel
            {
                Id = model.Id,
                StartTime = model.StartTime,
                EndTime = model.EndTime,
                RoomId = model.RoomId,
                CreatedAt = model.CreatedAt,
                DeletedAt = model.DeletedAt,
                UpdatedAt = model.UpdatedAt
            };
        }

        public static RoomSlot ToActivityFromCreate(this CreateRoomSlotRequestModel dto)
        {
            return new RoomSlot
            {
                StartTime = dto.StartTime,
                EndTime = dto.EndTime,
                RoomId = dto.RoomId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
        }
    }
}
