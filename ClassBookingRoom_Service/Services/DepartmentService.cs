using ClassBookingRoom_Repository;
using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.Department;
using ClassBookingRoom_Repository.ResponseModels.Department;
using ClassBookingRoom_Service.IServices;
using ClassBookingRoom_Service.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IBaseRepository<Department> _departmentRepo;

        public DepartmentService(IBaseRepository<Department> departmentRepo)
        {
            _departmentRepo = departmentRepo;
        }

        public Task<bool> Create(CreateDepartmentRequestModel dto)
        {
            return _departmentRepo.AddAsync(dto.ToDepartmentFromCreate());
        }

        public Task<bool> Delete(int id)
        {
            return _departmentRepo.DeleteAsync(id);
        }

        public async Task<List<DepartmentResponseModel>> GetAll()
        {
            var departments = await _departmentRepo.GetAllAsync();
            return departments.Select(x => x.ToDepartmentDTO()).ToList();
        }

        public async Task<DepartmentResponseModel?> GetById(int id)
        {
            var department = await _departmentRepo.GetByIdAsync(id);
            return department?.ToDepartmentDTO();
        }

        public async Task<bool> Update(int id, UpdateDepartmentRequestModel dto)
        {
            var department = await _departmentRepo.GetByIdAsync(id);
            if (department == null)
            {
                return false;
            }
            department.UpdatedAt = DateTime.Now;
            department.Name = dto.Name;
            return await _departmentRepo.UpdateAsync(department);
        }
    }
}
