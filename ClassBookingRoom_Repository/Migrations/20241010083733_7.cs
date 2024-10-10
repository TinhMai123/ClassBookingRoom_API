using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassBookingRoom_Repository.Migrations
{
    /// <inheritdoc />
    public partial class _7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("86220709-40be-4ace-bf20-17e3940748b6"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e465cbcb-3326-4555-ad1f-5b70ffbc3d75"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f546f722-d71c-467e-9e38-522801fc4b45"));

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "RoomType",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "RoomSlot",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Room",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Report",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Department",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Cohort",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "BookingModifyHistory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Booking",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Activity",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Cohort",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt", "isDeleted" },
                values: new object[] { new DateTime(2024, 10, 10, 15, 37, 33, 115, DateTimeKind.Local).AddTicks(7962), new DateTime(2024, 10, 10, 15, 37, 33, 115, DateTimeKind.Local).AddTicks(7963), false });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt", "isDeleted" },
                values: new object[] { new DateTime(2024, 10, 10, 15, 37, 33, 115, DateTimeKind.Local).AddTicks(7938), new DateTime(2024, 10, 10, 15, 37, 33, 115, DateTimeKind.Local).AddTicks(7939), false });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreateAt", "UpdatedAt", "isDeleted" },
                values: new object[] { new DateTime(2024, 10, 10, 8, 37, 33, 115, DateTimeKind.Utc).AddTicks(7908), new DateTime(2024, 10, 10, 8, 37, 33, 115, DateTimeKind.Utc).AddTicks(7908), false });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreateAt", "UpdatedAt", "isDeleted" },
                values: new object[] { new DateTime(2024, 10, 10, 8, 37, 33, 115, DateTimeKind.Utc).AddTicks(7906), new DateTime(2024, 10, 10, 8, 37, 33, 115, DateTimeKind.Utc).AddTicks(7906), false });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt", "isDeleted" },
                values: new object[] { new DateTime(2024, 10, 10, 8, 37, 33, 115, DateTimeKind.Utc).AddTicks(7903), new DateTime(2024, 10, 10, 8, 37, 33, 115, DateTimeKind.Utc).AddTicks(7903), false });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt", "isDeleted" },
                values: new object[] { new DateTime(2024, 10, 10, 15, 37, 33, 115, DateTimeKind.Local).AddTicks(7704), new DateTime(2024, 10, 10, 15, 37, 33, 115, DateTimeKind.Local).AddTicks(7715), false });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CohortId", "CreateAt", "DeleteAt", "DepartmentId", "Email", "FullName", "Password", "ProfileImageURL", "Role", "Status", "UpdatedAt", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("0d2a4edf-f2d9-4b42-8f93-811e3a505aee"), null, new DateTime(2024, 10, 10, 15, 37, 33, 115, DateTimeKind.Local).AddTicks(8032), null, -1, "manager@fpt.edu.vn", "John Doe", "123456", "https://placehold.co/600x400", "Manager", "Active", new DateTime(2024, 10, 10, 15, 37, 33, 115, DateTimeKind.Local).AddTicks(8034), false },
                    { new Guid("10c8e332-3aab-455e-8fae-afd90778898c"), null, new DateTime(2024, 10, 10, 15, 37, 33, 115, DateTimeKind.Local).AddTicks(8025), null, -1, "admin@fpt.edu.vn", "John Doe", "123456", "https://placehold.co/600x400", "Admin", "Active", new DateTime(2024, 10, 10, 15, 37, 33, 115, DateTimeKind.Local).AddTicks(8028), false },
                    { new Guid("3d364edc-51b1-4bdc-ba41-543da4624ad6"), -1, new DateTime(2024, 10, 10, 15, 37, 33, 115, DateTimeKind.Local).AddTicks(8037), null, -1, "student@fpt.edu.vn", "John Doe", "123456", "https://placehold.co/600x400", "Student", "Active", new DateTime(2024, 10, 10, 15, 37, 33, 115, DateTimeKind.Local).AddTicks(8038), false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0d2a4edf-f2d9-4b42-8f93-811e3a505aee"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("10c8e332-3aab-455e-8fae-afd90778898c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3d364edc-51b1-4bdc-ba41-543da4624ad6"));

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "User");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "RoomType");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "RoomSlot");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Cohort");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "BookingModifyHistory");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Activity");

            migrationBuilder.UpdateData(
                table: "Cohort",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 12, 53, 4, 604, DateTimeKind.Local).AddTicks(303), new DateTime(2024, 10, 9, 12, 53, 4, 604, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 12, 53, 4, 604, DateTimeKind.Local).AddTicks(279), new DateTime(2024, 10, 9, 12, 53, 4, 604, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 5, 53, 4, 604, DateTimeKind.Utc).AddTicks(248), new DateTime(2024, 10, 9, 5, 53, 4, 604, DateTimeKind.Utc).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 5, 53, 4, 604, DateTimeKind.Utc).AddTicks(246), new DateTime(2024, 10, 9, 5, 53, 4, 604, DateTimeKind.Utc).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 5, 53, 4, 604, DateTimeKind.Utc).AddTicks(241), new DateTime(2024, 10, 9, 5, 53, 4, 604, DateTimeKind.Utc).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 12, 53, 4, 604, DateTimeKind.Local).AddTicks(22), new DateTime(2024, 10, 9, 12, 53, 4, 604, DateTimeKind.Local).AddTicks(40) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CohortId", "CreateAt", "DeleteAt", "DepartmentId", "Email", "FullName", "Password", "ProfileImageURL", "Role", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("86220709-40be-4ace-bf20-17e3940748b6"), -1, new DateTime(2024, 10, 9, 12, 53, 4, 604, DateTimeKind.Local).AddTicks(391), null, -1, "student@fpt.edu.vn", "John Doe", "123456", "https://placehold.co/600x400", "Student", "Active", new DateTime(2024, 10, 9, 12, 53, 4, 604, DateTimeKind.Local).AddTicks(395) },
                    { new Guid("e465cbcb-3326-4555-ad1f-5b70ffbc3d75"), null, new DateTime(2024, 10, 9, 12, 53, 4, 604, DateTimeKind.Local).AddTicks(367), null, -1, "admin@fpt.edu.vn", "John Doe", "123456", "https://placehold.co/600x400", "Admin", "Active", new DateTime(2024, 10, 9, 12, 53, 4, 604, DateTimeKind.Local).AddTicks(372) },
                    { new Guid("f546f722-d71c-467e-9e38-522801fc4b45"), null, new DateTime(2024, 10, 9, 12, 53, 4, 604, DateTimeKind.Local).AddTicks(376), null, -1, "manager@fpt.edu.vn", "John Doe", "123456", "https://placehold.co/600x400", "Manager", "Active", new DateTime(2024, 10, 9, 12, 53, 4, 604, DateTimeKind.Local).AddTicks(378) }
                });
        }
    }
}
