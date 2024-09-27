using ClassBookingRoom_BusinessObject.DTO.RoomType;
using ClassBookingRoom_BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface IRoomTypeService
    {
        Task<bool> AddRoomTypeAsync(CreateRoomTypeDTO add);
        Task<bool> DeleteRoomTypeAsync(int id);
        Task<RoomTypeDTO?> GetRoomType(int id);
        Task<List<RoomTypeDTO>> GetRoomTypes();
        Task<bool> UpdateRoomTypeAsync(int id, UpdateRoomTypeDTO update);
    }
}
