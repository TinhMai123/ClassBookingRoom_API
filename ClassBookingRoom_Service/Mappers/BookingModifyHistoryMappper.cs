using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.BookingModifyHistory;
using ClassBookingRoom_Repository.ResponseModels.BookingModifyHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Mappers
{
    public static class BookingModifyHistoryMappper
    {
        public static BookingModifyHistoryResponseModel ToBookingModifyHistoryDTO(this BookingModifyHistory model)
        {
            var user = model.ModifiedBy?.ToUserShortDTO();
            return new BookingModifyHistoryResponseModel
            {
                Id = model.Id,
                BookingId = model.BookingId,
                ModifiedBy = user,
                ModifiedById = model.ModifiedById,
                ModifiedDate = model.ModifiedDate,
                NewStatus = model.NewStatus,
                OldStatus = model.OldStatus,
                CreatedAt = model.CreatedAt,
                DeletedAt = model.DeletedAt,
                UpdatedAt = model.UpdatedAt,
            };
        }

        public static BookingModifyHistory ToBookingModifyHistoryFromCreate(this CreateBookingModifyHistoryRequestModel dto)
        {
            return new BookingModifyHistory
            {
                BookingId = dto.BookingId,
                ModifiedById = dto.ModifiedById,
                ModifiedDate = dto.ModifiedDate,
                NewStatus = dto.NewStatus,
                OldStatus = dto.OldStatus,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
        }
    }
}
