using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassBookingRoom_Repository.Migrations
{
    /// <inheritdoc />
    public partial class Migration_9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8736b6d8-3d4d-463d-a61d-4e8a8f4c26e6"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b6a42ef6-fdfa-4e50-b138-bd1fb83e1ba7"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ee10fade-3c33-4fc9-a9bb-eaae9ac4c6e6"));

            migrationBuilder.AddColumn<DateTime>(
                name: "BookingDate",
                table: "Booking",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cohort",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 17, 3, 56, 125, DateTimeKind.Local).AddTicks(2673), new DateTime(2024, 10, 25, 17, 3, 56, 125, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 17, 3, 56, 125, DateTimeKind.Local).AddTicks(2657), new DateTime(2024, 10, 25, 17, 3, 56, 125, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 10, 3, 56, 125, DateTimeKind.Utc).AddTicks(2634), new DateTime(2024, 10, 25, 10, 3, 56, 125, DateTimeKind.Utc).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 10, 3, 56, 125, DateTimeKind.Utc).AddTicks(2632), new DateTime(2024, 10, 25, 10, 3, 56, 125, DateTimeKind.Utc).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 10, 3, 56, 125, DateTimeKind.Utc).AddTicks(2628), new DateTime(2024, 10, 25, 10, 3, 56, 125, DateTimeKind.Utc).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 17, 3, 56, 125, DateTimeKind.Local).AddTicks(2478), new DateTime(2024, 10, 25, 17, 3, 56, 125, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CohortId", "CreatedAt", "DeletedAt", "DepartmentId", "Email", "FullName", "IsDeleted", "IsVerify", "Note", "Password", "ProfileImageURL", "Role", "Status", "UpdatedAt", "VerifyToken" },
                values: new object[,]
                {
                    { new Guid("3701573a-85a8-49f7-ba9c-81d77e9a4874"), null, new DateTime(2024, 10, 25, 17, 3, 56, 125, DateTimeKind.Local).AddTicks(2724), null, -1, "admin@fpt.edu.vn", "John Doe", false, false, null, "123456", "https://placehold.co/600x400", "Admin", "Active", new DateTime(2024, 10, 25, 17, 3, 56, 125, DateTimeKind.Local).AddTicks(2726), null },
                    { new Guid("615526bc-5303-47e9-a015-4a5bf453acbc"), -1, new DateTime(2024, 10, 25, 17, 3, 56, 125, DateTimeKind.Local).AddTicks(2734), null, -1, "student@fpt.edu.vn", "John Doe", false, false, null, "123456", "https://placehold.co/600x400", "Student", "Active", new DateTime(2024, 10, 25, 17, 3, 56, 125, DateTimeKind.Local).AddTicks(2735), null },
                    { new Guid("ac51d47b-5e9e-40ec-8c9a-7486a5ddad98"), null, new DateTime(2024, 10, 25, 17, 3, 56, 125, DateTimeKind.Local).AddTicks(2729), null, -1, "manager@fpt.edu.vn", "John Doe", false, false, null, "123456", "https://placehold.co/600x400", "Manager", "Active", new DateTime(2024, 10, 25, 17, 3, 56, 125, DateTimeKind.Local).AddTicks(2731), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3701573a-85a8-49f7-ba9c-81d77e9a4874"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("615526bc-5303-47e9-a015-4a5bf453acbc"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ac51d47b-5e9e-40ec-8c9a-7486a5ddad98"));

            migrationBuilder.DropColumn(
                name: "BookingDate",
                table: "Booking");

            migrationBuilder.UpdateData(
                table: "Cohort",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 14, 42, 16, 209, DateTimeKind.Local).AddTicks(2593), new DateTime(2024, 10, 20, 14, 42, 16, 209, DateTimeKind.Local).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 14, 42, 16, 209, DateTimeKind.Local).AddTicks(2573), new DateTime(2024, 10, 20, 14, 42, 16, 209, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 7, 42, 16, 209, DateTimeKind.Utc).AddTicks(2524), new DateTime(2024, 10, 20, 7, 42, 16, 209, DateTimeKind.Utc).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 7, 42, 16, 209, DateTimeKind.Utc).AddTicks(2522), new DateTime(2024, 10, 20, 7, 42, 16, 209, DateTimeKind.Utc).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 7, 42, 16, 209, DateTimeKind.Utc).AddTicks(2519), new DateTime(2024, 10, 20, 7, 42, 16, 209, DateTimeKind.Utc).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 14, 42, 16, 209, DateTimeKind.Local).AddTicks(2383), new DateTime(2024, 10, 20, 14, 42, 16, 209, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CohortId", "CreatedAt", "DeletedAt", "DepartmentId", "Email", "FullName", "IsDeleted", "IsVerify", "Note", "Password", "ProfileImageURL", "Role", "Status", "UpdatedAt", "VerifyToken" },
                values: new object[,]
                {
                    { new Guid("8736b6d8-3d4d-463d-a61d-4e8a8f4c26e6"), -1, new DateTime(2024, 10, 20, 14, 42, 16, 209, DateTimeKind.Local).AddTicks(2661), null, -1, "student@fpt.edu.vn", "John Doe", false, false, null, "123456", "https://placehold.co/600x400", "Student", "Active", new DateTime(2024, 10, 20, 14, 42, 16, 209, DateTimeKind.Local).AddTicks(2662), null },
                    { new Guid("b6a42ef6-fdfa-4e50-b138-bd1fb83e1ba7"), null, new DateTime(2024, 10, 20, 14, 42, 16, 209, DateTimeKind.Local).AddTicks(2656), null, -1, "manager@fpt.edu.vn", "John Doe", false, false, null, "123456", "https://placehold.co/600x400", "Manager", "Active", new DateTime(2024, 10, 20, 14, 42, 16, 209, DateTimeKind.Local).AddTicks(2658), null },
                    { new Guid("ee10fade-3c33-4fc9-a9bb-eaae9ac4c6e6"), null, new DateTime(2024, 10, 20, 14, 42, 16, 209, DateTimeKind.Local).AddTicks(2643), null, -1, "admin@fpt.edu.vn", "John Doe", false, false, null, "123456", "https://placehold.co/600x400", "Admin", "Active", new DateTime(2024, 10, 20, 14, 42, 16, 209, DateTimeKind.Local).AddTicks(2645), null }
                });
        }
    }
}
