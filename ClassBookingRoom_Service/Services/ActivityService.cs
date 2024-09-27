using ClassBookingRoom_BusinessObject.DTO.Activity;
using ClassBookingRoom_BusinessObject.Models;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository;
using ClassBookingRoom_Service.IServices;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassBookingRoom_BusinessObject.Mappers;

namespace ClassBookingRoom_Service.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepo _repo;
        private readonly IBaseRepository<Activity> _baseRepo;

        public ActivityService(IActivityRepo repo, IBaseRepository<Activity> baseRepo)
        {
            _repo = repo;
            _baseRepo = baseRepo;
        }

        public async Task<bool> CreateAsync(CreateActivityDTO add)
        {
            return await _baseRepo.AddAsync(add.ToActivityFromCreate());
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _baseRepo.DeleteAsync(id);
        }

        public async Task<List<ActivityDTO>> GetAll()
        {
            var activities = await _baseRepo.GetAllAsync();
            return activities.Select(x => x.ToAcivityDTO()).ToList();
        }

        public async Task<ActivityDTO?> GetById(int id)
        {
            var activity = await _baseRepo.GetByIdAsync(id);
            return activity?.ToAcivityDTO();
        }

        public async Task<bool> UpdateAsync(int id, UpdateActivityDTO update)
        {
            var activity =await _baseRepo.GetByIdAsync(id);
            if (activity is null) { return false; }
            activity.Name = update.Name;
            activity.DepartmentId = update.DepartmentId;
            activity.UpdatedAt = DateTime.UtcNow;
            return await _baseRepo.UpdateAsync(activity);
        }
    }
}
