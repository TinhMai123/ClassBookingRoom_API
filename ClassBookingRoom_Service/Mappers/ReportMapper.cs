using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.Report;
using ClassBookingRoom_Repository.ResponseModels.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Mappers
{
    public static class ReportMapper
    {
        public static ReportResponseModel ToReportDTO(this Report model)
        {
            return new ReportResponseModel
            {
                Id = model.Id,
                CreatedAt = model.CreatedAt,
                DeletedAt = model.DeletedAt,
                Description = model.Description,
                Title = model.Title,
                UpdatedAt = model.UpdatedAt,
                StudentId = model.CreatorId,
                StudentFullName = model.CreatedBy?.FullName ?? "" ,
                StudentEmail = model.CreatedBy?.Email ?? "",
                RoomId = model.RoomId,
                Status = model.Status,
                RoomName = model.Room?.RoomName ?? "",
                Response = model.Response
            };
        }
        public static Report CreateReportFromDTO(this CreateReportRequestModel dto)
        {
            return new Report
            {
                Description = dto.Description,
                Title = dto.Title,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                CreatorId= dto.CreatorId,
                RoomId= dto.RoomId,
            };
        }
    }
}
