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
    [Migration("20241010085845_8")]
    partial class _8
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

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

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

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

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

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

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

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Cohort");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CohortCode = "K17",
                            CreateAt = new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(2018),
                            UpdatedAt = new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(2019),
                            isDeleted = false
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

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CreateAt = new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(1990),
                            Name = "IT",
                            UpdatedAt = new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(1992),
                            isDeleted = false
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

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Room");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Capacity = 10,
                            CreateAt = new DateTime(2024, 10, 10, 8, 58, 44, 806, DateTimeKind.Utc).AddTicks(1945),
                            RoomName = "101",
                            RoomTypeId = -1,
                            Status = "Open",
                            UpdatedAt = new DateTime(2024, 10, 10, 8, 58, 44, 806, DateTimeKind.Utc).AddTicks(1945),
                            isDeleted = false
                        },
                        new
                        {
                            Id = -2,
                            Capacity = 10,
                            CreateAt = new DateTime(2024, 10, 10, 8, 58, 44, 806, DateTimeKind.Utc).AddTicks(1950),
                            RoomName = "102",
                            RoomTypeId = -1,
                            Status = "Open",
                            UpdatedAt = new DateTime(2024, 10, 10, 8, 58, 44, 806, DateTimeKind.Utc).AddTicks(1950),
                            isDeleted = false
                        },
                        new
                        {
                            Id = -3,
                            Capacity = 10,
                            CreateAt = new DateTime(2024, 10, 10, 8, 58, 44, 806, DateTimeKind.Utc).AddTicks(1952),
                            RoomName = "103",
                            RoomTypeId = -1,
                            Status = "Closed",
                            UpdatedAt = new DateTime(2024, 10, 10, 8, 58, 44, 806, DateTimeKind.Utc).AddTicks(1952),
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("ClassBookingRoom_Repository.Models.RoomSlot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

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

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("RoomType");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CreateAt = new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(1509),
                            Name = "RoomT1",
                            UpdatedAt = new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(1579),
                            isDeleted = false
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

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVerify")
                        .HasColumnType("bit");

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

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CohortId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8729756e-9e6b-4bd3-af49-32800a55c467"),
                            CreateAt = new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(2087),
                            DepartmentId = -1,
                            Email = "admin@fpt.edu.vn",
                            FullName = "John Doe",
                            IsVerify = false,
                            Password = "123456",
                            ProfileImageURL = "https://placehold.co/600x400",
                            Role = "Admin",
                            Status = "Active",
                            UpdatedAt = new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(2091),
                            isDeleted = false
                        },
                        new
                        {
                            Id = new Guid("e38e2796-c216-415d-8bd1-9dccb7799f21"),
                            CreateAt = new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(2096),
                            DepartmentId = -1,
                            Email = "manager@fpt.edu.vn",
                            FullName = "John Doe",
                            IsVerify = false,
                            Password = "123456",
                            ProfileImageURL = "https://placehold.co/600x400",
                            Role = "Manager",
                            Status = "Active",
                            UpdatedAt = new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(2098),
                            isDeleted = false
                        },
                        new
                        {
                            Id = new Guid("bce44053-4489-44ab-8a03-e39c523c04e8"),
                            CohortId = -1,
                            CreateAt = new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(2102),
                            DepartmentId = -1,
                            Email = "student@fpt.edu.vn",
                            FullName = "John Doe",
                            IsVerify = false,
                            Password = "123456",
                            ProfileImageURL = "https://placehold.co/600x400",
                            Role = "Student",
                            Status = "Active",
                            UpdatedAt = new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(2103),
                            isDeleted = false
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
                        .WithMany("Users")
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

                    b.Navigation("Users");
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
