using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassBookingRoom_Repository.Migrations
{
    /// <inheritdoc />
    public partial class Migration_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cohort",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CohortCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cohort", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activity_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    CohortId = table.Column<int>(type: "int", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Cohort_CohortId",
                        column: x => x.CohortId,
                        principalTable: "Cohort",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomTypeId = table.Column<int>(type: "int", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room_RoomType_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoomTypeCohort",
                columns: table => new
                {
                    AllowedCohortsId = table.Column<int>(type: "int", nullable: false),
                    RoomTypesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypeCohort", x => new { x.AllowedCohortsId, x.RoomTypesId });
                    table.ForeignKey(
                        name: "FK_RoomTypeCohort_Cohort_AllowedCohortsId",
                        column: x => x.AllowedCohortsId,
                        principalTable: "Cohort",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomTypeCohort_RoomType_RoomTypesId",
                        column: x => x.RoomTypesId,
                        principalTable: "RoomType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivityRoomType",
                columns: table => new
                {
                    ActivitiesId = table.Column<int>(type: "int", nullable: false),
                    RoomTypesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityRoomType", x => new { x.ActivitiesId, x.RoomTypesId });
                    table.ForeignKey(
                        name: "FK_ActivityRoomType_Activity_ActivitiesId",
                        column: x => x.ActivitiesId,
                        principalTable: "Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityRoomType_RoomType_RoomTypesId",
                        column: x => x.RoomTypesId,
                        principalTable: "RoomType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Report_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Report_User_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomSlot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomSlot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomSlot_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingModifyHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OldStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingModifyHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingModifyHistory_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingModifyHistory_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookingRoomSlot",
                columns: table => new
                {
                    BookingsId = table.Column<int>(type: "int", nullable: false),
                    RoomSlotsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingRoomSlot", x => new { x.BookingsId, x.RoomSlotsId });
                    table.ForeignKey(
                        name: "FK_BookingRoomSlot_Booking_BookingsId",
                        column: x => x.BookingsId,
                        principalTable: "Booking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingRoomSlot_RoomSlot_RoomSlotsId",
                        column: x => x.RoomSlotsId,
                        principalTable: "RoomSlot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cohort",
                columns: new[] { "Id", "CohortCode", "CreateAt", "DeleteAt", "UpdatedAt" },
                values: new object[] { -1, "K17", new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5539), null, new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "Name", "UpdatedAt" },
                values: new object[] { -1, new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5524), null, "IT", new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "Name", "UpdatedAt" },
                values: new object[] { -1, new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5389), null, "RoomT1", new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "Capacity", "CreateAt", "DeleteAt", "RoomName", "RoomTypeId", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { -3, 10, new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5505), null, "103", -1, "Closed", new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5505) },
                    { -2, 10, new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5503), null, "102", -1, "Open", new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5503) },
                    { -1, 10, new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5499), null, "101", -1, "Open", new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5500) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CohortId", "CreateAt", "DeleteAt", "DepartmentId", "Email", "FirstName", "LastName", "Password", "ProfileImageURL", "Role", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("34f0f961-220f-4d6c-84f8-f150c057f399"), -1, new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5644), null, -1, "student@fpt.edu.vn", "John", "Doe", "123456", "https://placehold.co/600x400", "Student", "Active", new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5646) },
                    { new Guid("f8480ce3-0c24-4c26-8c3b-490d77905253"), null, new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5602), null, -1, "manager@fpt.edu.vn", "John", "Doe", "123456", "https://placehold.co/600x400", "Manager", "Active", new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5604) },
                    { new Guid("ffc478ee-3ea3-4978-9316-81dcba64df1e"), null, new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5585), null, -1, "admin@fpt.edu.vn", "John", "Doe", "123456", "https://placehold.co/600x400", "Admin", "Active", new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5588) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activity_DepartmentId",
                table: "Activity",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityRoomType_RoomTypesId",
                table: "ActivityRoomType",
                column: "RoomTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ActivityId",
                table: "Booking",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_UserId",
                table: "Booking",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingModifyHistory_BookingId",
                table: "BookingModifyHistory",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingModifyHistory_ModifiedById",
                table: "BookingModifyHistory",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_BookingRoomSlot_RoomSlotsId",
                table: "BookingRoomSlot",
                column: "RoomSlotsId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_CreatorId",
                table: "Report",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_RoomId",
                table: "Report",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomTypeId",
                table: "Room",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomSlot_RoomId",
                table: "RoomSlot",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomTypeCohort_RoomTypesId",
                table: "RoomTypeCohort",
                column: "RoomTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CohortId",
                table: "User",
                column: "CohortId");

            migrationBuilder.CreateIndex(
                name: "IX_User_DepartmentId",
                table: "User",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityRoomType");

            migrationBuilder.DropTable(
                name: "BookingModifyHistory");

            migrationBuilder.DropTable(
                name: "BookingRoomSlot");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "RoomTypeCohort");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "RoomSlot");

            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Cohort");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "RoomType");
        }
    }
}
