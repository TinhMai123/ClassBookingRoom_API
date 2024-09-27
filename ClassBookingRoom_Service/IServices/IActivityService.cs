using ClassBookingRoom_BusinessObject.DTO.Activity;
using ClassBookingRoom_BusinessObject.DTO.RoomType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface IActivityService
    {
        Task<bool> CreateAsync(CreateActivityDTO add);
        Task<bool> DeleteAsync(int id);
        Task<ActivityDTO?> GetById(int id);
        Task<List<ActivityDTO>> GetAll();
        Task<bool> UpdateAsync(int id, UpdateActivityDTO update);
    }
}
