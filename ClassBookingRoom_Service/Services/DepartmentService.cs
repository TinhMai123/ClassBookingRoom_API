using ClassBookingRoom_BusinessObject.DTO.Department;
using ClassBookingRoom_BusinessObject.Mappers;
using ClassBookingRoom_BusinessObject.Models;
using ClassBookingRoom_Repository;
using ClassBookingRoom_Service.IServices;
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

        public Task<bool> Create(CreateDepartmentDTO dto)
        {
            return _departmentRepo.AddAsync(dto.ToDepartmentFromCreate());
        }

        public Task<bool> Delete(int id)
        {
            return _departmentRepo.DeleteAsync(id);
        }

        public async Task<List<DepartmentDTO>> GetAll()
        {
            var departments = await _departmentRepo.GetAllAsync();
            return departments.Select(x => x.ToDepartmentDTO()).ToList();
        }

        public async Task<DepartmentDTO?> GetById(int id)
        {
            var department = await _departmentRepo.GetByIdAsync(id);
            return department?.ToDepartmentDTO();
        }

        public async Task<bool> Update(int id, UpdateDepartmentDTO dto)
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
