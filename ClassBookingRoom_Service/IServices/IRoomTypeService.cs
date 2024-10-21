using ClassBookingRoom_Repository.RequestModels.RoomType;
using ClassBookingRoom_Repository.ResponseModels.RoomType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface IRoomTypeService
    {
        Task<bool> AddRoomTypeAsync(CreateRoomTypeRequestModel add);
        Task<bool> DeleteRoomTypeAsync(int id);
        Task<RoomTypeResponseModel?> GetRoomType(int id);
        Task<List<RoomTypeResponseModel>> GetRoomTypes();
        Task<bool> UpdateRoomTypeAsync(int id, UpdateRoomTypeRequestModel update);
        Task<(List<RoomTypeResponseModel>, int)> SearchRoomType(SearchRoomTypeQuery query);
        Task RemoveCohort(int id, int cohortId);
        Task RemoveActivity(int id, int activityId);
        Task AddCohort(int id, int cohortId);
        Task AddActivity(int id, int activityId);
    }
}
