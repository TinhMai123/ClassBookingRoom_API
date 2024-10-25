using ClassBookingRoom_Repository;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.Activity;
using ClassBookingRoom_Repository.ResponseModels.Activity;
using ClassBookingRoom_Service.IServices;
using ClassBookingRoom_Service.Mappers;

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

        public async Task<bool> CreateAsync(CreateActivityRequestModel add)
        {
            var activity = await _repo.GetActivityByCode(add.Code);
            if
                (activity == null) { return await _baseRepo.AddAsync(add.ToActivityFromCreate()); }
            return false;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _baseRepo.DeleteAsync(id);
        }

        public async Task<List<ActivityResponseModel>> GetAll()
        {
            var activities = await _repo.GetActivities();
            return activities.Select(x => x.ToAcivityDTO()).ToList();
        }

        public async Task<ActivityResponseModel?> GetById(int id)
        {
            var activity = await _repo.GetActivityById(id);
            return activity?.ToAcivityDTO();
        }

        public async Task<bool> UpdateAsync(int id, UpdateActivityRequestModel update)
        {
            var activity = await _baseRepo.GetByIdAsync(id);
            var code = await _repo.GetActivityByCode(update.Code);
            if (activity is null || code != null) { return false; }
            activity.Name = update.Name;
            activity.Code = update.Code;
            activity.UpdatedAt = DateTime.UtcNow;
            return await _baseRepo.UpdateAsync(activity);
        }
    }
}
