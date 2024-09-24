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
        public DbSet<Campus> Campuses { get; set; }
        public DbSet<BookingActivity> BookingActivities { get; set; }
        public DbSet<BookingDepartment> BookingDepartments { get; set;}
     }

}
