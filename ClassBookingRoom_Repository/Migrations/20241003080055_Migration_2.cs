using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassBookingRoom_Repository.Migrations
{
    /// <inheritdoc />
    public partial class Migration_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("34f0f961-220f-4d6c-84f8-f150c057f399"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f8480ce3-0c24-4c26-8c3b-490d77905253"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ffc478ee-3ea3-4978-9316-81dcba64df1e"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "RoomSlot",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "RoomSlot",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "RoomSlot",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "RoomSlot");

            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "RoomSlot");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "RoomSlot");

            migrationBuilder.UpdateData(
                table: "Cohort",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5539), new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5524), new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5505), new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5503), new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5499), new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5389), new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CohortId", "CreateAt", "DeleteAt", "DepartmentId", "Email", "FirstName", "LastName", "Password", "ProfileImageURL", "Role", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("34f0f961-220f-4d6c-84f8-f150c057f399"), -1, new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5644), null, -1, "student@fpt.edu.vn", "John", "Doe", "123456", "https://placehold.co/600x400", "Student", "Active", new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5646) },
                    { new Guid("f8480ce3-0c24-4c26-8c3b-490d77905253"), null, new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5602), null, -1, "manager@fpt.edu.vn", "John", "Doe", "123456", "https://placehold.co/600x400", "Manager", "Active", new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5604) },
                    { new Guid("ffc478ee-3ea3-4978-9316-81dcba64df1e"), null, new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5585), null, -1, "admin@fpt.edu.vn", "John", "Doe", "123456", "https://placehold.co/600x400", "Admin", "Active", new DateTime(2024, 10, 1, 20, 42, 36, 415, DateTimeKind.Local).AddTicks(5588) }
                });
        }
    }
}
