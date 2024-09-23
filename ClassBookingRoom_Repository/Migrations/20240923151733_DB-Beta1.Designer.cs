﻿// <auto-generated />
using System;
using ClassBookingRoom_Repository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClassBookingRoom_Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240923151733_DB-Beta1")]
    partial class DBBeta1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.AllowedCohort", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CohortId")
                        .HasColumnType("int");

                    b.Property<int?>("RoomTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CohortId");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("AllowedCohort");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreateById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CreateById");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("RoomId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.BookingActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ActivityId")
                        .HasColumnType("int");

                    b.Property<int?>("BookingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("BookingId");

                    b.ToTable("BookingActivities");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.BookingDepartment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("BookingId")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("BookingDepartments");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.BookingSlot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BookingId")
                        .HasColumnType("int");

                    b.Property<int?>("RoomSlotId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.HasIndex("RoomSlotId");

                    b.ToTable("BookingSlot");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Campus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("HotLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Campus");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Cohort", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CohortCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Cohort");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.HasIndex("UserId");

                    b.ToTable("Report");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.RoomSlot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<TimeOnly>("EndTime")
                        .HasColumnType("time");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomSlot");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("RoomType");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("CampusId")
                        .HasColumnType("int");

                    b.Property<int?>("CohortId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CampusId");

                    b.HasIndex("CohortId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Activity", b =>
                {
                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Department", "Department")
                        .WithMany("Activities")
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.AllowedCohort", b =>
                {
                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Cohort", "Cohort")
                        .WithMany("AllowedCohorts")
                        .HasForeignKey("CohortId");

                    b.HasOne("ClassBookingRoom_BusinessObject.Models.RoomType", "RoomType")
                        .WithMany("AllowedCohorts")
                        .HasForeignKey("RoomTypeId");

                    b.Navigation("Cohort");

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Booking", b =>
                {
                    b.HasOne("ClassBookingRoom_BusinessObject.Models.User", "CreateBy")
                        .WithMany()
                        .HasForeignKey("CreateById");

                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Department", null)
                        .WithMany("Bookings")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Room", "Room")
                        .WithMany("Bookings")
                        .HasForeignKey("RoomId");

                    b.Navigation("CreateBy");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.BookingActivity", b =>
                {
                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Activity", "Activity")
                        .WithMany("BookingActivities")
                        .HasForeignKey("ActivityId");

                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Booking", "Booking")
                        .WithMany("BookingActivities")
                        .HasForeignKey("BookingId");

                    b.Navigation("Activity");

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.BookingDepartment", b =>
                {
                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingId");

                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Booking");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.BookingSlot", b =>
                {
                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Booking", "Booking")
                        .WithMany("BookingSlots")
                        .HasForeignKey("BookingId");

                    b.HasOne("ClassBookingRoom_BusinessObject.Models.RoomSlot", "RoomSlot")
                        .WithMany("BookingSlots")
                        .HasForeignKey("RoomSlotId");

                    b.Navigation("Booking");

                    b.Navigation("RoomSlot");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Report", b =>
                {
                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Room", "Room")
                        .WithMany("Reports")
                        .HasForeignKey("RoomId");

                    b.HasOne("ClassBookingRoom_BusinessObject.Models.User", "User")
                        .WithMany("Reports")
                        .HasForeignKey("UserId");

                    b.Navigation("Room");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Room", b =>
                {
                    b.HasOne("ClassBookingRoom_BusinessObject.Models.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeId");

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.RoomSlot", b =>
                {
                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Room", "Room")
                        .WithMany("RoomSlots")
                        .HasForeignKey("RoomId");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.RoomType", b =>
                {
                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.User", b =>
                {
                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Campus", "Campus")
                        .WithMany("Users")
                        .HasForeignKey("CampusId");

                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Cohort", "Cohort")
                        .WithMany("Users")
                        .HasForeignKey("CohortId");

                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Campus");

                    b.Navigation("Cohort");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Activity", b =>
                {
                    b.Navigation("BookingActivities");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Booking", b =>
                {
                    b.Navigation("BookingActivities");

                    b.Navigation("BookingSlots");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Campus", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Cohort", b =>
                {
                    b.Navigation("AllowedCohorts");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Department", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Room", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Reports");

                    b.Navigation("RoomSlots");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.RoomSlot", b =>
                {
                    b.Navigation("BookingSlots");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.RoomType", b =>
                {
                    b.Navigation("AllowedCohorts");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.User", b =>
                {
                    b.Navigation("Reports");
                });
#pragma warning restore 612, 618
        }
    }
}