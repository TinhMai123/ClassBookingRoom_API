using ClassBookingRoom_Repository.RequestModels.Report;
using ClassBookingRoom_Repository.ResponseModels.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface IReportService
    {
        Task<bool> AddAsync(CreateReportRequestModel add);
        Task<bool> DeleteAsync(int id);
        Task<ReportResponseModel?> GetById(int id);
        Task<List<ReportResponseModel>> GetAll();
        Task<bool> UpdateAsync(int id,UpdateReportRequestModel update);
    }
}
