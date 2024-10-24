﻿using ClassBookingRoom_Repository;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Repos;
using ClassBookingRoom_Service;
using ClassBookingRoom_Service.IServices;
using ClassBookingRoom_Service.Services;
using System.Configuration;
namespace ClassBookingRoom_API.Helper
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServicesConfiguration(this IServiceCollection services)
        {
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IUserRepo, UserRepo>();
            services.AddTransient<IBookingRepo, BookingRepo>();
            services.AddTransient<IRoomRepo, RoomRepo>();
            services.AddTransient<IRoomTypeRepo, RoomTypeRepo>();
            services.AddTransient<ICohortRepo, CohortRepo>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IActivityRepo, ActivityRepo>();
            services.AddTransient<IRoomSlotRepo, RoomSlotRepo>();
            services.AddTransient<IDepartmentRepo, DepartmentRepo>();
            services.AddTransient<IBookingModifyHistoryRepo, BookingModifyHistoryRepo>();
            services.AddTransient<IFaceDescriptorRepo, FaceDescriptorRepo>();
            services.AddTransient<IFaceDescriptorService, FaceDescriptorService>();
            return services;
            
        }
    }
}
