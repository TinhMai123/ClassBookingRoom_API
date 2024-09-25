﻿using ClassBookingRoom_BusinessObject;
using ClassBookingRoom_BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.IRepos
{
    public interface IRoomTypeRepo
    {
        Task<bool> AddRoomTypeAsync(RoomType add);
        Task<bool> DeleteRoomTypeAsync(int id);
        Task<RoomType> GetRoomType(int id);
        Task<List<RoomType>> GetRoomTypes();
        Task<RoomType> GetRoomTypeByName(string name);
        Task<bool> UpdateRoomTypeAsync(RoomType update);
    }
}
