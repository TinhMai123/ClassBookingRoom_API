using ClassBookingRoom_BusinessObject.DTO.Department;
using ClassBookingRoom_BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface IDepartmentService
    {
        Task<bool> Create(CreateDepartmentDTO dto);
        Task<bool> Delete(int id);
        Task<DepartmentDTO?> GetById(int id);
        Task<List<DepartmentDTO>> GetAll();
        Task<bool> Update(int id, UpdateDepartmentDTO dto);
    }
}
