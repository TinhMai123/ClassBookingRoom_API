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
            var slots = model.RoomSlots?.Select(c => c.ToRoomSlotsFromRoomDTO()).ToList();
            var bookings = new List<Booking>();
            foreach (RoomSlot slot in model.RoomSlots)
            {
                foreach (Booking booking in slot.Bookings)
                {
                    if (bookings.FirstOrDefault(x => x.Id == booking.Id) is null)
                    {
                        bookings.Add(booking);
                    }
                }

            }
            var numOfPendingBooking = bookings.Count;
            return new RoomResponseModel()
            {
                Id = model.Id,
                Capacity = model.Capacity,
                RoomName = model.RoomName,
                RoomTypeId = model.RoomTypeId,
                RoomType = model.RoomType.ToRoomTypeDTO(),
                RoomSlots = slots ?? [],
                Picture = model.Picture,
                Status = model.Status,
                CreatedAt = model.CreatedAt,
                DeletedAt = model.DeletedAt,
                UpdatedAt = model.UpdatedAt,
                NumOfPendingBooking = numOfPendingBooking,
            };
        }

        public static Room ToRoomFromCreate(this CreateRoomRequestModel dto)
        {
            return new Room()
            {
                Capacity = dto.Capacity,
                RoomName = dto.RoomName,
                RoomTypeId = dto.RoomTypeId,
                Picture = dto.Picture,
                Status = dto.Status,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
        }
    }
}
