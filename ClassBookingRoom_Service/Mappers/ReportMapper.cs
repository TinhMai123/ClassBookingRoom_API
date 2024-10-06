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
                CreateAt = model.CreateAt,
                DeleteAt = model.DeleteAt,
                Description = model.Description,
                Title = model.Title,
                UpdatedAt = model.UpdatedAt,
                StudentId = model.CreatorId,
                StudentFirstName = model.CreatedBy?.FirstName ?? "",
                StudentLastName = model.CreatedBy?.LastName ?? "",
                StudentEmail = model.CreatedBy?.Email ?? "",
                RoomId = model.RoomId,
            };
        }
        public static Report CreateReportFromDTO(this CreateReportRequestModel dto)
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
