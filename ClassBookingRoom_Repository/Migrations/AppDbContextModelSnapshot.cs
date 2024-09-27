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

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.HasIndex("DepartmentId");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Booking", b =>
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

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("RoomId");

                    b.HasIndex("UserId");

                    b.ToTable("Booking");
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
                            CreateAt = new DateTime(2024, 9, 27, 21, 8, 34, 953, DateTimeKind.Local).AddTicks(6112),
                            UpdatedAt = new DateTime(2024, 9, 27, 21, 8, 34, 953, DateTimeKind.Local).AddTicks(6113)
                        });
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Department", b =>
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
                            CreateAt = new DateTime(2024, 9, 27, 21, 8, 34, 953, DateTimeKind.Local).AddTicks(6096),
                            Name = "IT",
                            UpdatedAt = new DateTime(2024, 9, 27, 21, 8, 34, 953, DateTimeKind.Local).AddTicks(6097)
                        });
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.News", b =>
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Report", b =>
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
                            CreateAt = new DateTime(2024, 9, 27, 21, 8, 34, 953, DateTimeKind.Local).AddTicks(6071),
                            RoomName = "101",
                            RoomTypeId = -1,
                            Status = "Open",
                            UpdatedAt = new DateTime(2024, 9, 27, 21, 8, 34, 953, DateTimeKind.Local).AddTicks(6072)
                        },
                        new
                        {
                            Id = -2,
                            Capacity = 10,
                            CreateAt = new DateTime(2024, 9, 27, 21, 8, 34, 953, DateTimeKind.Local).AddTicks(6075),
                            RoomName = "102",
                            RoomTypeId = -1,
                            Status = "Open",
                            UpdatedAt = new DateTime(2024, 9, 27, 21, 8, 34, 953, DateTimeKind.Local).AddTicks(6075)
                        },
                        new
                        {
                            Id = -3,
                            Capacity = 10,
                            CreateAt = new DateTime(2024, 9, 27, 21, 8, 34, 953, DateTimeKind.Local).AddTicks(6077),
                            RoomName = "103",
                            RoomTypeId = -1,
                            Status = "Closed",
                            UpdatedAt = new DateTime(2024, 9, 27, 21, 8, 34, 953, DateTimeKind.Local).AddTicks(6077)
                        });
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.RoomSlot", b =>
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

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("RoomType");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CreateAt = new DateTime(2024, 9, 27, 21, 8, 34, 953, DateTimeKind.Local).AddTicks(5934),
                            DepartmentId = -1,
                            Name = "RoomT1",
                            UpdatedAt = new DateTime(2024, 9, 27, 21, 8, 34, 953, DateTimeKind.Local).AddTicks(5935)
                        });
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.User", b =>
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
                            Id = new Guid("89b278a1-9643-4c12-83dd-66cf5177da69"),
                            CreateAt = new DateTime(2024, 9, 27, 21, 8, 34, 953, DateTimeKind.Local).AddTicks(6163),
                            DepartmentId = -1,
                            Email = "admin@fpt.edu.vn",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "123456",
                            ProfileImageURL = "https://placehold.co/600x400",
                            Role = "Admin",
                            Status = "Active",
                            UpdatedAt = new DateTime(2024, 9, 27, 21, 8, 34, 953, DateTimeKind.Local).AddTicks(6166)
                        },
                        new
                        {
                            Id = new Guid("53a16bfb-c2e1-4a40-bee2-630617b3c2cf"),
                            CreateAt = new DateTime(2024, 9, 27, 21, 8, 34, 953, DateTimeKind.Local).AddTicks(6169),
                            DepartmentId = -1,
                            Email = "manager@fpt.edu.vn",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "123456",
                            ProfileImageURL = "https://placehold.co/600x400",
                            Role = "Manager",
                            Status = "Active",
                            UpdatedAt = new DateTime(2024, 9, 27, 21, 8, 34, 953, DateTimeKind.Local).AddTicks(6170)
                        },
                        new
                        {
                            Id = new Guid("f746a6af-afc9-4930-bc14-0f30d930c927"),
                            CohortId = -1,
                            CreateAt = new DateTime(2024, 9, 27, 21, 8, 34, 953, DateTimeKind.Local).AddTicks(6173),
                            DepartmentId = -1,
                            Email = "student@fpt.edu.vn",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "123456",
                            ProfileImageURL = "https://placehold.co/600x400",
                            Role = "Student",
                            Status = "Active",
                            UpdatedAt = new DateTime(2024, 9, 27, 21, 8, 34, 953, DateTimeKind.Local).AddTicks(6175)
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

            modelBuilder.Entity("BookingRoomSlot", b =>
                {
                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Booking", null)
                        .WithMany()
                        .HasForeignKey("BookingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassBookingRoom_BusinessObject.Models.RoomSlot", null)
                        .WithMany()
                        .HasForeignKey("RoomSlotsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Activity", b =>
                {
                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Department", "Department")
                        .WithMany("Activities")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Booking", b =>
                {
                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Room", null)
                        .WithMany("Bookings")
                        .HasForeignKey("RoomId");

                    b.HasOne("ClassBookingRoom_BusinessObject.Models.User", "CreateBy")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("CreateBy");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.News", b =>
                {
                    b.HasOne("ClassBookingRoom_BusinessObject.Models.User", "CreatedBy")
                        .WithMany("Newss")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Report", b =>
                {
                    b.HasOne("ClassBookingRoom_BusinessObject.Models.User", "CreatedBy")
                        .WithMany("Reports")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Room", "Room")
                        .WithMany("Reports")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("Room");
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
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.RoomType", b =>
                {
                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.User", b =>
                {
                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Cohort", "Cohort")
                        .WithMany("Users")
                        .HasForeignKey("CohortId");

                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Cohort");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("CohortRoomType", b =>
                {
                    b.HasOne("ClassBookingRoom_BusinessObject.Models.Cohort", null)
                        .WithMany()
                        .HasForeignKey("AllowedCohortsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassBookingRoom_BusinessObject.Models.RoomType", null)
                        .WithMany()
                        .HasForeignKey("RoomTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Cohort", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Department", b =>
                {
                    b.Navigation("Activities");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.Room", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Reports");

                    b.Navigation("RoomSlots");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.RoomType", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("ClassBookingRoom_BusinessObject.Models.User", b =>
                {
                    b.Navigation("Newss");

                    b.Navigation("Reports");
                });
#pragma warning restore 612, 618
        }
    }
}
