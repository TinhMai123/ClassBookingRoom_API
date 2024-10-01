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
    [Migration("20241001134236_Migration_1")]
    partial class Migration_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ActivityRoomType", b =>
                {
                    b.Property<int>("ActivitiesId")
                        .HasColumnType("int");

                    b.Property<int>("RoomTypesId")
                        .HasColumnType("int");

                    b.HasKey("ActivitiesId", "RoomTypesId");

                    b.HasIndex("RoomTypesId");

                    b.ToTable("ActivityRoomType", (string)null);
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
                            CreateAt = new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5539),
                            UpdatedAt = new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5539)
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
                            CreateAt = new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5524),
                            Name = "IT",
                            UpdatedAt = new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5525)
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
                            CreateAt = new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5499),
                            RoomName = "101",
                            RoomTypeId = -1,
                            Status = "Open",
                            UpdatedAt = new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5500)
                        },
                        new
                        {
                            Id = -2,
                            Capacity = 10,
                            CreateAt = new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5503),
                            RoomName = "102",
                            RoomTypeId = -1,
                            Status = "Open",
                            UpdatedAt = new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5503)
                        },
                        new
                        {
                            Id = -3,
                            Capacity = 10,
                            CreateAt = new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5505),
                            RoomName = "103",
                            RoomTypeId = -1,
                            Status = "Closed",
                            UpdatedAt = new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5505)
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
                            CreateAt = new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5389),
                            Name = "RoomT1",
                            UpdatedAt = new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5390)
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
                            Id = new Guid("ffc478ee-3ea3-4978-9316-81dcba64df1e"),
                            CreateAt = new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5585),
                            DepartmentId = -1,
                            Email = "admin@fpt.edu.vn",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "123456",
                            ProfileImageURL = "https://placehold.co/600x400",
                            Role = "Admin",
                            Status = "Active",
                            UpdatedAt = new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5588)
                        },
                        new
                        {
                            Id = new Guid("f8480ce3-0c24-4c26-8c3b-490d77905253"),
                            CreateAt = new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5602),
                            DepartmentId = -1,
                            Email = "manager@fpt.edu.vn",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "123456",
                            ProfileImageURL = "https://placehold.co/600x400",
                            Role = "Manager",
                            Status = "Active",
                            UpdatedAt = new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5604)
                        },
                        new
                        {
                            Id = new Guid("34f0f961-220f-4d6c-84f8-f150c057f399"),
                            CohortId = -1,
                            CreateAt = new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5644),
                            DepartmentId = -1,
                            Email = "student@fpt.edu.vn",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "123456",
                            ProfileImageURL = "https://placehold.co/600x400",
                            Role = "Student",
                            Status = "Active",
                            UpdatedAt = new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5646)
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

            modelBuilder.Entity("ActivityRoomType", b =>
                {
                    b.HasOne("ClassBookingRoom_Repository.Models.Activity", null)
                        .WithMany()
                        .HasForeignKey("ActivitiesId")
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
                    b.HasOne("ClassBookingRoom_Repository.Models.Department", "Department")
                        .WithMany("Activities")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
                        .WithMany("Bookings")
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
                        .OnDelete(DeleteBehavior.Cascade)
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

                    b.Navigation("Bookings");

                    b.Navigation("Reports");
                });
#pragma warning restore 612, 618
        }
    }
}