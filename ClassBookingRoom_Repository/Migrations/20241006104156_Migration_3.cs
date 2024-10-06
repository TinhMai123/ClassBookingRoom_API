using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassBookingRoom_Repository.Migrations
{
    /// <inheritdoc />
    public partial class Migration_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0b9faabc-6fc1-4359-a9e3-e5bd1b82b1bd"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9e1a8a36-3f6c-4782-bf8d-499001aeed4d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d3cd9b9e-f48a-4b82-91e9-1f1e206b9a8a"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "RoomSlot",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "RoomSlot",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Room",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cohort",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 6, 17, 41, 55, 199, DateTimeKind.Local).AddTicks(9509), new DateTime(2024, 10, 6, 17, 41, 55, 199, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 6, 17, 41, 55, 199, DateTimeKind.Local).AddTicks(9492), new DateTime(2024, 10, 6, 17, 41, 55, 199, DateTimeKind.Local).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 6, 10, 41, 55, 199, DateTimeKind.Utc).AddTicks(9468), new DateTime(2024, 10, 6, 10, 41, 55, 199, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 6, 10, 41, 55, 199, DateTimeKind.Utc).AddTicks(9466), new DateTime(2024, 10, 6, 10, 41, 55, 199, DateTimeKind.Utc).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 6, 10, 41, 55, 199, DateTimeKind.Utc).AddTicks(9460), new DateTime(2024, 10, 6, 10, 41, 55, 199, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 6, 17, 41, 55, 199, DateTimeKind.Local).AddTicks(9275), new DateTime(2024, 10, 6, 17, 41, 55, 199, DateTimeKind.Local).AddTicks(9287) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CohortId", "CreateAt", "DeleteAt", "DepartmentId", "Email", "FirstName", "LastName", "Password", "ProfileImageURL", "Role", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("01636116-5a61-45c0-b5ae-dc03d066caf1"), null, new DateTime(2024, 10, 6, 17, 41, 55, 199, DateTimeKind.Local).AddTicks(9574), null, -1, "manager@fpt.edu.vn", "John", "Doe", "123456", "https://placehold.co/600x400", "Manager", "Active", new DateTime(2024, 10, 6, 17, 41, 55, 199, DateTimeKind.Local).AddTicks(9576) },
                    { new Guid("cc52c92d-7858-4200-844b-f46c0eddd025"), null, new DateTime(2024, 10, 6, 17, 41, 55, 199, DateTimeKind.Local).AddTicks(9568), null, -1, "admin@fpt.edu.vn", "John", "Doe", "123456", "https://placehold.co/600x400", "Admin", "Active", new DateTime(2024, 10, 6, 17, 41, 55, 199, DateTimeKind.Local).AddTicks(9571) },
                    { new Guid("fe8e75b5-19e7-4833-9557-8c7a45fc2efb"), -1, new DateTime(2024, 10, 6, 17, 41, 55, 199, DateTimeKind.Local).AddTicks(9579), null, -1, "student@fpt.edu.vn", "John", "Doe", "123456", "https://placehold.co/600x400", "Student", "Active", new DateTime(2024, 10, 6, 17, 41, 55, 199, DateTimeKind.Local).AddTicks(9580) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("01636116-5a61-45c0-b5ae-dc03d066caf1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("cc52c92d-7858-4200-844b-f46c0eddd025"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fe8e75b5-19e7-4833-9557-8c7a45fc2efb"));

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "StartTime",
                table: "RoomSlot",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "EndTime",
                table: "RoomSlot",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Room",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Cohort",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 15, 0, 53, 893, DateTimeKind.Local).AddTicks(4578), new DateTime(2024, 10, 3, 15, 0, 53, 893, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 15, 0, 53, 893, DateTimeKind.Local).AddTicks(4522), new DateTime(2024, 10, 3, 15, 0, 53, 893, DateTimeKind.Local).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 15, 0, 53, 893, DateTimeKind.Local).AddTicks(4495), new DateTime(2024, 10, 3, 15, 0, 53, 893, DateTimeKind.Local).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 15, 0, 53, 893, DateTimeKind.Local).AddTicks(4493), new DateTime(2024, 10, 3, 15, 0, 53, 893, DateTimeKind.Local).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 15, 0, 53, 893, DateTimeKind.Local).AddTicks(4488), new DateTime(2024, 10, 3, 15, 0, 53, 893, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 15, 0, 53, 893, DateTimeKind.Local).AddTicks(4330), new DateTime(2024, 10, 3, 15, 0, 53, 893, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CohortId", "CreateAt", "DeleteAt", "DepartmentId", "Email", "FirstName", "LastName", "Password", "ProfileImageURL", "Role", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0b9faabc-6fc1-4359-a9e3-e5bd1b82b1bd"), null, new DateTime(2024, 10, 3, 15, 0, 53, 893, DateTimeKind.Local).AddTicks(4646), null, -1, "manager@fpt.edu.vn", "John", "Doe", "123456", "https://placehold.co/600x400", "Manager", "Active", new DateTime(2024, 10, 3, 15, 0, 53, 893, DateTimeKind.Local).AddTicks(4648) },
                    { new Guid("9e1a8a36-3f6c-4782-bf8d-499001aeed4d"), null, new DateTime(2024, 10, 3, 15, 0, 53, 893, DateTimeKind.Local).AddTicks(4639), null, -1, "admin@fpt.edu.vn", "John", "Doe", "123456", "https://placehold.co/600x400", "Admin", "Active", new DateTime(2024, 10, 3, 15, 0, 53, 893, DateTimeKind.Local).AddTicks(4643) },
                    { new Guid("d3cd9b9e-f48a-4b82-91e9-1f1e206b9a8a"), -1, new DateTime(2024, 10, 3, 15, 0, 53, 893, DateTimeKind.Local).AddTicks(4651), null, -1, "student@fpt.edu.vn", "John", "Doe", "123456", "https://placehold.co/600x400", "Student", "Active", new DateTime(2024, 10, 3, 15, 0, 53, 893, DateTimeKind.Local).AddTicks(4653) }
                });
        }
    }
}
