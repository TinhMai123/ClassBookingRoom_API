using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassBookingRoom_Repository.Migrations
{
    /// <inheritdoc />
    public partial class _8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsVerify",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Cohort",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(2018), new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(1990), new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 8, 58, 44, 806, DateTimeKind.Utc).AddTicks(1952), new DateTime(2024, 10, 10, 8, 58, 44, 806, DateTimeKind.Utc).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 8, 58, 44, 806, DateTimeKind.Utc).AddTicks(1950), new DateTime(2024, 10, 10, 8, 58, 44, 806, DateTimeKind.Utc).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 8, 58, 44, 806, DateTimeKind.Utc).AddTicks(1945), new DateTime(2024, 10, 10, 8, 58, 44, 806, DateTimeKind.Utc).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(1509), new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(1579) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CohortId", "CreateAt", "DeleteAt", "DepartmentId", "Email", "FullName", "IsVerify", "Password", "ProfileImageURL", "Role", "Status", "UpdatedAt", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("8729756e-9e6b-4bd3-af49-32800a55c467"), null, new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(2087), null, -1, "admin@fpt.edu.vn", "John Doe", false, "123456", "https://placehold.co/600x400", "Admin", "Active", new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(2091), false },
                    { new Guid("bce44053-4489-44ab-8a03-e39c523c04e8"), -1, new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(2102), null, -1, "student@fpt.edu.vn", "John Doe", false, "123456", "https://placehold.co/600x400", "Student", "Active", new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(2103), false },
                    { new Guid("e38e2796-c216-415d-8bd1-9dccb7799f21"), null, new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(2096), null, -1, "manager@fpt.edu.vn", "John Doe", false, "123456", "https://placehold.co/600x400", "Manager", "Active", new DateTime(2024, 10, 10, 15, 58, 44, 806, DateTimeKind.Local).AddTicks(2098), false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8729756e-9e6b-4bd3-af49-32800a55c467"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bce44053-4489-44ab-8a03-e39c523c04e8"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e38e2796-c216-415d-8bd1-9dccb7799f21"));

            migrationBuilder.DropColumn(
                name: "IsVerify",
                table: "User");

            migrationBuilder.UpdateData(
                table: "Cohort",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 15, 37, 33, 115, DateTimeKind.Local).AddTicks(7962), new DateTime(2024, 10, 10, 15, 37, 33, 115, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 15, 37, 33, 115, DateTimeKind.Local).AddTicks(7938), new DateTime(2024, 10, 10, 15, 37, 33, 115, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 8, 37, 33, 115, DateTimeKind.Utc).AddTicks(7908), new DateTime(2024, 10, 10, 8, 37, 33, 115, DateTimeKind.Utc).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 8, 37, 33, 115, DateTimeKind.Utc).AddTicks(7906), new DateTime(2024, 10, 10, 8, 37, 33, 115, DateTimeKind.Utc).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 8, 37, 33, 115, DateTimeKind.Utc).AddTicks(7903), new DateTime(2024, 10, 10, 8, 37, 33, 115, DateTimeKind.Utc).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 15, 37, 33, 115, DateTimeKind.Local).AddTicks(7704), new DateTime(2024, 10, 10, 15, 37, 33, 115, DateTimeKind.Local).AddTicks(7715) });

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
    }
}
