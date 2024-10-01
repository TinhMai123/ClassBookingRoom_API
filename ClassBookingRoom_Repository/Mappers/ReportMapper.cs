using ClassBookingRoom_BusinessObject.DTO.Report;
using ClassBookingRoom_BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Mappers
{
    public static class ReportMapper
    {
        public static ReportDTO ToReportDTO(this Report model)
        {
            var user = model.CreatedBy?.ToUserDTO();
            return new ReportDTO
            {
                Id = model.Id,
                CreateAt = model.CreateAt,
                DeleteAt = model.DeleteAt,
                Description = model.Description,
                Title = model.Title,
                UpdatedAt = model.UpdatedAt,
                CreatedBy = user,
                CreatorId = model.CreatorId,
                RoomId = model.RoomId,
            };
        }
        public static Report CreateReportFromDTO(this CreateReportDTO dto)
        {
            return new Report
            {
                Description = dto.Description,
                Title = dto.Title,
                CreateAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatorId= dto.CreatorId,
                RoomId= dto.RoomId,
            };
        }
    }
}
