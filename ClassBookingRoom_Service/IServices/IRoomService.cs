using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.Room;
using ClassBookingRoom_Repository.ResponseModels.Booking;
using ClassBookingRoom_Repository.ResponseModels.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface IRoomService
    {
        Task<bool> AddRoomAsync(CreateRoomRequestModel add);
        Task<bool> DeleteRoomAsync(int id);
        Task<RoomResponseModel?> GetRoom(int id);
        Task<List<RoomResponseModel>> GetRooms();
        Task<List<BookingResponseModel>> GetBookingsByRoomId(int roomId);
        Task<bool> UpdateRoomAsync(int id, UpdateRoomRequestModel update);
        Task<(List<RoomResponseModel> response, int totalCount)>SearchRoomQuery(SearchRoomQuery query);
    }
}
