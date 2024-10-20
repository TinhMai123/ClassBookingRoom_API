using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository;
using ClassBookingRoom_Service.IServices;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassBookingRoom_Repository.ResponseModels.RoomType;
using ClassBookingRoom_Repository.RequestModels.RoomType;
using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Service.Mappers;
using ClassBookingRoom_Repository.RequestModels.User;
using ClassBookingRoom_Repository.ResponseModels.User;

namespace ClassBookingRoom_Service.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IRoomTypeRepo _repo;
        private readonly IBaseRepository<RoomType> _baseRepo;
        private readonly IBaseRepository<Activity> _baseActivityRepo;
        private readonly IBaseRepository<Cohort> _baseCohortRepo;

        public RoomTypeService(IRoomTypeRepo repo, IBaseRepository<RoomType> baseRepo, 
            IBaseRepository<Activity> baseActivityRepo, IBaseRepository<Cohort> baseCohortRepo)
        {
            _repo = repo;
            _baseRepo = baseRepo;
            _baseActivityRepo = baseActivityRepo;
            _baseCohortRepo = baseCohortRepo;
        }

        public async Task<bool> AddRoomTypeAsync(CreateRoomTypeRequestModel dto)
        {
            return await _baseRepo.AddAsync(dto.ToRoomTypeFromCreate());
        }

        public async Task<bool> DeleteRoomTypeAsync(int id)
        {

            return await _baseRepo.DeleteAsync(id);
        }


        public async Task<RoomTypeResponseModel?> GetRoomType(int id)
        {
            var roomType = await _baseRepo.GetByIdAsync(id);
            return roomType?.ToRoomTypeDTO();
        }

        public async Task<List<RoomTypeResponseModel>> GetRoomTypes()
        {
            var rooms =await _baseRepo.GetAllAsync();
            return rooms.Select(x => x.ToRoomTypeDTO()).ToList();
        }

        public async Task<bool> UpdateRoomTypeAsync(int id, UpdateRoomTypeRequestModel update)
        {
            var roomType = await _baseRepo.GetByIdAsync(id);
            if (roomType is null)
            {
                return false;
            }
            roomType.UpdatedAt = DateTime.UtcNow;
            roomType.Name = update.Name;
            return await _baseRepo.UpdateAsync(roomType);
        }
        public async Task<(List<RoomTypeResponseModel>, int)> SearchRoomType(SearchRoomTypeQuery query)
        {
            var modelList = await _baseRepo.GetAllAsync();
            var result = modelList.AsQueryable();
            if (!string.IsNullOrWhiteSpace(query.SearchValue))
            {
                result = result.Where(c => c.Name.Contains(query.SearchValue));
            }
            if (!string.IsNullOrWhiteSpace(query.CohortCode))
            {
                result = result.Where(c => c.AllowedCohorts.Select(c=>c.CohortCode).Contains(query.CohortCode));
            }
            if (!string.IsNullOrWhiteSpace(query.ActivityName))
            {
                result = result.Where(c => c.Activities.Select(c=>c.Name).Contains(query.ActivityName));
            }

            var totalCount = result.Count();
            var skipNumber = (query.PageNumber - 1) * query.PageSize;
            var classResult = result.Skip(skipNumber).Take(query.PageSize).ToList();
            return (classResult.Select(x => x.ToRoomTypeDTO()).ToList(), totalCount);
        }
        public async Task RemoveRoomTypeAttribute(RoomTypeAttributeRequestModel model)
        {
            var roomType = await _baseRepo.GetByIdAsync(model.RoomTypeId);
            if (roomType == null)
            {
                throw new Exception("RoomType not found");
            }
            var cohort = roomType.AllowedCohorts.FirstOrDefault(c => c.Id == model.CohortId);
            if (cohort != null)
            {
                roomType.AllowedCohorts.Remove(cohort);
            }

            var activity = roomType.Activities.FirstOrDefault(a => a.Id == model.ActivityId);
            if (activity != null)
            {
                roomType.Activities.Remove(activity);
            }
            await _baseRepo.UpdateAsync(roomType);
        }
        public async Task AddNewRoomTypeAttribute(RoomTypeAttributeRequestModel model)
        {
            var roomType = await _repo.GetRoomTypeById(model.RoomTypeId);

            if (roomType == null)
            {
                throw new Exception("RoomType not found");
            }

            if (!roomType.AllowedCohorts.Any(c => c.Id == model.CohortId))
            {
                var cohort = new Cohort { Id = model.CohortId };
                _baseCohortRepo.AttachEntity(cohort);
                roomType.AllowedCohorts.Add(cohort);
            }
            if (!roomType.Activities.Any(a => a.Id == model.ActivityId))
            {
                var activity = new Activity { Id = model.ActivityId };
                _baseActivityRepo.AttachEntity(activity);
                roomType.Activities.Add(activity);
            }
            await _baseRepo.UpdateAsync(roomType);
        }
    }
}
