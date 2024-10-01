using ClassBookingRoom_Repository.RequestModels.Department;
using ClassBookingRoom_Repository.ResponseModels.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface IDepartmentService
    {
        Task<bool> Create(CreateDepartmentRequestModel dto);
        Task<bool> Delete(int id);
        Task<DepartmentResponseModel?> GetById(int id);
        Task<List<DepartmentResponseModel>> GetAll();
        Task<bool> Update(int id, UpdateDepartmentRequestModel dto);
    }
}
