using ClassBookingRoom_BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Cohort> Cohorts { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomsTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<AllowedCohort> AllowedCohorts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<BookingSlot> BookingSlots { get; set; }
        public DbSet<RoomSlot> RoomSlots { get; set; }
        public DbSet<BookingActivity> BookingActivities { get; set; }
        public DbSet<BookingDepartment> BookingDepartments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding data

            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    Id = -1,
                    Name = "IT",
                    CreateAt = DateTime.Now,
                    DeleteAt = null,
                    UpdatedAt = DateTime.Now,

                });
            modelBuilder.Entity<Cohort>().HasData(
                new Cohort
                {
                    Id = -1,
                    CreateAt = DateTime.Now,
                    DeleteAt = null,
                    UpdatedAt = DateTime.Now,
                    CohortCode = "K17"
                }
                );
            
            modelBuilder.Entity<User>().HasData(
          new User
          {
              Id = Guid.NewGuid(),
              CohortId = null,
              DepartmentId = -1,
              CreateAt = DateTime.Now,
              DeleteAt = null,
              Email = "admin@fpt.edu.vn",
              FirstName = "John",
              LastName = "Doe",
              Password = "123456",
              ProfileImageURL = "https://placehold.co/600x400",
              Role = "Admin",
              Status = "Active",
              UpdatedAt = DateTime.Now
          },
           new User
           {
               Id = Guid.NewGuid(),
               CohortId = null,
               DepartmentId = -1,
               CreateAt = DateTime.Now,
               DeleteAt = null,
               Email = "manager@fpt.edu.vn",
               FirstName = "John",
               LastName = "Doe",
               Password = "123456",
               ProfileImageURL = "https://placehold.co/600x400",
               Role = "Manager",
               Status = "Active",
               UpdatedAt = DateTime.Now
           },
            new User
            {
                Id = Guid.NewGuid(),
                CohortId = -1,
                DepartmentId = -1,
                CreateAt = DateTime.Now,
                DeleteAt = null,
                Email = "student@fpt.edu.vn",
                FirstName = "John",
                LastName = "Doe",
                Password = "123456",
                ProfileImageURL = "https://placehold.co/600x400",
                Role = "Student",
                Status = "Active",
                UpdatedAt = DateTime.Now
            }
      );
        }
    }

}
