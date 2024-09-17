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
        public DbSet<Team> Teams { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<UserTeam> UserTeams { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<AllowedCohorts> AllowedCohorts { get; set; }
        public DbSet<Campus> Campus { get; set; }

    }

}
