using ClassBookingRoom_Repository;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.Department;
using ClassBookingRoom_Repository.ResponseModels.Activity;
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
        private readonly IBaseRepository<Department> _baseRepo;
        private readonly IDepartmentRepo _repo;
        private readonly IActivityRepo _activityRepo;

        public DepartmentService(IBaseRepository<Department> baseRepo, IDepartmentRepo repo, IActivityRepo activityRepo)
        {
            _baseRepo = baseRepo;
            _repo = repo;
            _activityRepo = activityRepo;
        }

        public async Task<bool> Create(CreateDepartmentRequestModel dto)
        {
            var check = await _repo.GetDepartmentByName(dto.Name);
            if(check == null) { return await _baseRepo.AddAsync(dto.ToDepartmentFromCreate()); }
            return false;
        }

        public async Task<bool> Delete(int id)
        {
            return await _baseRepo.DeleteAsync(id);
        }

        public async Task<List<ActivityResponseModel>> GetActivitiesByDepartmentId(int departmentId)
        {
            var activities =  await _activityRepo.GetActivitiesByDepartmentId(departmentId);
            return activities.Select(a => a.ToAcivityDTO()).ToList();
        }

        public async Task<List<DepartmentResponseModel>> GetAll()
        {
            var departments = await _repo.GetDepartments();
            return departments.Select(x => x.ToDepartmentDTO()).ToList();
        }

        public async Task<DepartmentResponseModel?> GetById(int id)
        {
            var department = await _repo.GetDepartmentById(id);
            return department?.ToDepartmentDTO();
        }

        public async Task<bool> Update(int id, UpdateDepartmentRequestModel dto)
        {
            var department = await _baseRepo.GetByIdAsync(id);
            var name = await _repo.GetDepartmentByName(dto.Name);
            if (department == null || name !=null)
            {
                return false;
            }
            department.UpdatedAt = DateTime.UtcNow;
            department.Name = dto.Name;
            return await _baseRepo.UpdateAsync(department);
        }
    }
}
