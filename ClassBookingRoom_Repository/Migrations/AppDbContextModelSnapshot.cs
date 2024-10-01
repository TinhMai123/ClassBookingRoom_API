﻿// <auto-generated />
using System;
using ClassBookingRoom_Repository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClassBookingRoom_Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ActivityTypeRoomType", b =>
                {
                    b.Property<int>("ActivityTypesId")
                        .HasColumnType("int");

                    b.Property<int>("RoomTypesId")
                        .HasColumnType("int");

                    b.HasKey("ActivityTypesId", "RoomTypesId");

                    b.HasIndex("RoomTypesId");

                    b.ToTable("ActivityTypeRoomType", (string)null);
                });

            modelBuilder.Entity("BookingRoomSlot", b =>
                {
                    b.Property<int>("BookingsId")
                        .HasColumnType("int");

                    b.Property<int>("RoomSlotsId")
                        .HasColumnType("int");

                    b.HasKey("BookingsId", "RoomSlotsId");

                    b.HasIndex("RoomSlotsId");

                    b.ToTable("BookingRoomSlot", (string)null);
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActivityTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ActivityTypeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.ActivityType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ActivityType");
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("UserId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.BookingModifyHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NewStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OldStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.HasIndex("ModifiedById");

                    b.ToTable("BookingModifyHistory");
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.Cohort", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CohortCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Cohort");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CohortCode = "K17",
                            CreateAt = new DateTime(2024, 10, 1, 15, 45, 58, 943, DateTimeKind.Local).AddTicks(1600),
                            UpdatedAt = new DateTime(2024, 10, 1, 15, 45, 58, 943, DateTimeKind.Local).AddTicks(1600)
                        });
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CreateAt = new DateTime(2024, 10, 1, 15, 45, 58, 943, DateTimeKind.Local).AddTicks(1578),
                            Name = "IT",
                            UpdatedAt = new DateTime(2024, 10, 1, 15, 45, 58, 943, DateTimeKind.Local).AddTicks(1578)
                        });
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("RoomId");

                    b.ToTable("Report");
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
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

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Capacity = 10,
                            CreateAt = new DateTime(2024, 10, 1, 15, 45, 58, 943, DateTimeKind.Local).AddTicks(1550),
                            RoomName = "101",
                            RoomTypeId = -1,
                            Status = "Open",
                            UpdatedAt = new DateTime(2024, 10, 1, 15, 45, 58, 943, DateTimeKind.Local).AddTicks(1551)
                        },
                        new
                        {
                            Id = -2,
                            Capacity = 10,
                            CreateAt = new DateTime(2024, 10, 1, 15, 45, 58, 943, DateTimeKind.Local).AddTicks(1555),
                            RoomName = "102",
                            RoomTypeId = -1,
                            Status = "Open",
                            UpdatedAt = new DateTime(2024, 10, 1, 15, 45, 58, 943, DateTimeKind.Local).AddTicks(1555)
                        },
                        new
                        {
                            Id = -3,
                            Capacity = 10,
                            CreateAt = new DateTime(2024, 10, 1, 15, 45, 58, 943, DateTimeKind.Local).AddTicks(1557),
                            RoomName = "103",
                            RoomTypeId = -1,
                            Status = "Closed",
                            UpdatedAt = new DateTime(2024, 10, 1, 15, 45, 58, 943, DateTimeKind.Local).AddTicks(1557)
                        });
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.RoomSlot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<TimeOnly>("EndTime")
                        .HasColumnType("time");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomSlot");
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("RoomType");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CreateAt = new DateTime(2024, 10, 1, 15, 45, 58, 943, DateTimeKind.Local).AddTicks(1436),
                            Name = "RoomT1",
                            UpdatedAt = new DateTime(2024, 10, 1, 15, 45, 58, 943, DateTimeKind.Local).AddTicks(1438)
                        });
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("CohortId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
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

                    b.HasIndex("CohortId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("60dc12dc-9c4a-4649-bf8b-fe4df9c00b9e"),
                            CreateAt = new DateTime(2024, 10, 1, 15, 45, 58, 943, DateTimeKind.Local).AddTicks(1644),
                            DepartmentId = -1,
                            Email = "admin@fpt.edu.vn",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "123456",
                            ProfileImageURL = "https://placehold.co/600x400",
                            Role = "Admin",
                            Status = "Active",
                            UpdatedAt = new DateTime(2024, 10, 1, 15, 45, 58, 943, DateTimeKind.Local).AddTicks(1648)
                        },
                        new
                        {
                            Id = new Guid("99a2353b-dd0f-436d-872b-f0d91630ddfa"),
                            CreateAt = new DateTime(2024, 10, 1, 15, 45, 58, 943, DateTimeKind.Local).AddTicks(1651),
                            DepartmentId = -1,
                            Email = "manager@fpt.edu.vn",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "123456",
                            ProfileImageURL = "https://placehold.co/600x400",
                            Role = "Manager",
                            Status = "Active",
                            UpdatedAt = new DateTime(2024, 10, 1, 15, 45, 58, 943, DateTimeKind.Local).AddTicks(1652)
                        },
                        new
                        {
                            Id = new Guid("17cfbe21-2960-485d-94d4-d194b3d97b5e"),
                            CohortId = -1,
                            CreateAt = new DateTime(2024, 10, 1, 15, 45, 58, 943, DateTimeKind.Local).AddTicks(1655),
                            DepartmentId = -1,
                            Email = "student@fpt.edu.vn",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "123456",
                            ProfileImageURL = "https://placehold.co/600x400",
                            Role = "Student",
                            Status = "Active",
                            UpdatedAt = new DateTime(2024, 10, 1, 15, 45, 58, 943, DateTimeKind.Local).AddTicks(1656)
                        });
                });

            modelBuilder.Entity("CohortRoomType", b =>
                {
                    b.Property<int>("AllowedCohortsId")
                        .HasColumnType("int");

                    b.Property<int>("RoomTypesId")
                        .HasColumnType("int");

                    b.HasKey("AllowedCohortsId", "RoomTypesId");

                    b.HasIndex("RoomTypesId");

                    b.ToTable("RoomTypeCohort", (string)null);
                });

            modelBuilder.Entity("ActivityTypeRoomType", b =>
                {
                    b.HasOne("ClassBookingRoom_Repository.Models.ActivityType", null)
                        .WithMany()
                        .HasForeignKey("ActivityTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassBookingRoom_Repository.Models.RoomType", null)
                        .WithMany()
                        .HasForeignKey("RoomTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookingRoomSlot", b =>
                {
                    b.HasOne("ClassBookingRoom_Repository.Models.Booking", null)
                        .WithMany()
                        .HasForeignKey("BookingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassBookingRoom_Repository.Models.RoomSlot", null)
                        .WithMany()
                        .HasForeignKey("RoomSlotsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.Activity", b =>
                {
                    b.HasOne("ClassBookingRoom_Repository.Models.ActivityType", "ActivityType")
                        .WithMany("Activities")
                        .HasForeignKey("ActivityTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassBookingRoom_Repository.Models.Department", "Department")
                        .WithMany("Activities")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActivityType");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.Booking", b =>
                {
                    b.HasOne("ClassBookingRoom_Repository.Models.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassBookingRoom_Repository.Models.User", "CreateBy")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("CreateBy");
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.BookingModifyHistory", b =>
                {
                    b.HasOne("ClassBookingRoom_Repository.Models.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassBookingRoom_Repository.Models.User", "ModifiedBy")
                        .WithMany("BookingModifyHistories")
                        .HasForeignKey("ModifiedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("ModifiedBy");
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.Report", b =>
                {
                    b.HasOne("ClassBookingRoom_Repository.Models.User", "CreatedBy")
                        .WithMany("Reports")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ClassBookingRoom_Repository.Models.Room", "Room")
                        .WithMany("Reports")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.Room", b =>
                {
                    b.HasOne("ClassBookingRoom_Repository.Models.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeId");

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.RoomSlot", b =>
                {
                    b.HasOne("ClassBookingRoom_Repository.Models.Room", "Room")
                        .WithMany("RoomSlots")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.User", b =>
                {
                    b.HasOne("ClassBookingRoom_Repository.Models.Cohort", "Cohort")
                        .WithMany("Users")
                        .HasForeignKey("CohortId");

                    b.HasOne("ClassBookingRoom_Repository.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Cohort");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("CohortRoomType", b =>
                {
                    b.HasOne("ClassBookingRoom_Repository.Models.Cohort", null)
                        .WithMany()
                        .HasForeignKey("AllowedCohortsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassBookingRoom_Repository.Models.RoomType", null)
                        .WithMany()
                        .HasForeignKey("RoomTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.ActivityType", b =>
                {
                    b.Navigation("Activities");
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.Cohort", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.Department", b =>
                {
                    b.Navigation("Activities");
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.Room", b =>
                {
                    b.Navigation("Reports");

                    b.Navigation("RoomSlots");
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.RoomType", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.User", b =>
                {
                    b.Navigation("BookingModifyHistories");

                    b.Navigation("Reports");
                });
#pragma warning restore 612, 618
        }
    }
}
