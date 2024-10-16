using ClassBookingRoom_Repository.Models;
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
        public DbSet<Department> Departments { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<RoomSlot> RoomSlots { get; set; }
        public DbSet<BookingModifyHistory> BookingModifyHistories { get; set; }
        public DbSet<FaceDescriptor> FaceDescriptors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cohort>()
                .HasMany(x => x.RoomTypes)
                .WithMany(x => x.AllowedCohorts)
                .UsingEntity(x => x.ToTable("RoomTypeCohort"));
            modelBuilder.Entity<Booking>()
                .HasMany(x => x.RoomSlots)
                .WithMany(x => x.Bookings)
                .UsingEntity(x => x.ToTable("BookingRoomSlot"));
            modelBuilder.Entity<Report>()
                .HasOne(x => x.CreatedBy)
                .WithMany(x => x.Reports)
                .HasForeignKey(x => x.CreatorId);
            modelBuilder.Entity<RoomType>()
                .HasMany(x => x.Activities)
                .WithMany(x => x.RoomTypes)
                .UsingEntity(x => x.ToTable("ActivityRoomType"));
            modelBuilder.Entity<BookingModifyHistory>()
                .HasOne(x => x.ModifiedBy)
                .WithMany(x => x.BookingModifyHistories)
                .HasForeignKey(x => x.ModifiedById)
                .OnDelete(DeleteBehavior.Restrict);
            // Seeding data
            modelBuilder.Entity<RoomType>().HasData(
                new RoomType
                {
                    Id = -1,
                    Name = "RoomT1",
                    CreatedAt = DateTime.Now,
                    DeletedAt = null,
                    UpdatedAt = DateTime.Now,
                }
                );
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    Id = -1,
                    Capacity = 10,
                    RoomName = "101",
                    RoomTypeId = -1,
                    Status = "Open"
                },
                new Room
                {
                    Id = -2,
                    Capacity = 10,
                    RoomName = "102",
                    RoomTypeId = -1,
                    Status = "Open"
                },
                new Room
                {
                    Id = -3,
                    Capacity = 10,
                    RoomName = "103",
                    RoomTypeId = -1,
                    Status = "Closed"
                }
            );
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    Id = -1,
                    Name = "IT",
                    CreatedAt = DateTime.Now,
                    DeletedAt = null,
                    UpdatedAt = DateTime.Now,

                });
            modelBuilder.Entity<Cohort>()
                .HasData(
                new Cohort
                {
                    Id = -1,
                    CreatedAt = DateTime.Now,
                    DeletedAt = null,
                    UpdatedAt = DateTime.Now,
                    CohortCode = "K17"
                }
                )
                ;

            modelBuilder.Entity<User>().HasData(
          new User
          {
              Id = Guid.NewGuid(),
              CohortId = null,
              DepartmentId = -1,
              CreatedAt = DateTime.Now,
              DeletedAt = null,
              Email = "admin@fpt.edu.vn",
              FullName="John Doe",
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
               CreatedAt = DateTime.Now,
               DeletedAt = null,
               Email = "manager@fpt.edu.vn",
               FullName = "John Doe",
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
                CreatedAt = DateTime.Now,
                DeletedAt = null,
                Email = "student@fpt.edu.vn",
                FullName = "John Doe",
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
