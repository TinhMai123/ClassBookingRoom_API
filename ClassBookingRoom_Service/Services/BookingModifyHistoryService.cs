﻿using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository;
using ClassBookingRoom_Repository.RequestModels.BookingModifyHistory;
using ClassBookingRoom_Repository.ResponseModels.BookingModifyHistory;
using ClassBookingRoom_Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Service.Mappers;

namespace ClassBookingRoom_Service.Services
{
    public class BookingModifyHistoryService : IBookingModifyHistoryService
    {
        private readonly IBookingModifyHistoryRepo _repo;

        public BookingModifyHistoryService(IBookingModifyHistoryRepo repo)
        {
            _repo = repo;
        }
        public async Task<bool> AddAsync(CreateBookingModifyHistoryRequestModel add)
        {
            return await _repo.AddAsync(add.ToBookingModifyHistoryFromCreate());
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repo.DeleteAsync(id);
        }

        public async Task<BookingModifyHistoryResponseModel?> Get(int id)
        {
            var result = await _repo.GetBookingModifyHistoryById(id);
            return result?.ToBookingModifyHistoryDTO();
        }

        public async Task<List<BookingModifyHistoryResponseModel>> GetByBookingid(int bookingId)
        {
            var result = await _repo.GetBookingModifyHistories();
            result = result.Where(x => x.BookingId == bookingId).ToList();
            return result.Select(x => x.ToBookingModifyHistoryDTO()).ToList();
        }

        public async Task<List<BookingModifyHistoryResponseModel>> Gets()
        {
            var result = await _repo.GetBookingModifyHistories();
            return result.Select(x => x.ToBookingModifyHistoryDTO()).ToList();
        }

        public async Task<bool> UpdateAsync(int id, UpdateBookingModifyHistoryRequestModel update)
        {
            var result = await _repo.GetBookingModifyHistoryById(id);
            if (result is null) { return false; }
            result.ModifiedDate = update.ModifiedDate;
            result.NewStatus = update.NewStatus;
            result.OldStatus = update.OldStatus;
            return await _repo.UpdateAsync(result);
        }
    }
}
