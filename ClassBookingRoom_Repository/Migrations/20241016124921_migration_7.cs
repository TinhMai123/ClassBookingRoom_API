using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassBookingRoom_Repository.Migrations
{
    /// <inheritdoc />
    public partial class migration_7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2ef14666-40c4-4a22-bdd7-4aa811696abc"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("40fd9286-0995-4d49-90a1-6371db487206"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9bdf04d1-75ab-400a-81fe-ab0d3399696b"));

            migrationBuilder.AlterColumn<string>(
                name: "Descriptor",
                table: "FaceDescriptors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "FaceDescriptors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Cohort",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 49, 20, 591, DateTimeKind.Local).AddTicks(8048), new DateTime(2024, 10, 16, 19, 49, 20, 591, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 49, 20, 591, DateTimeKind.Local).AddTicks(8023), new DateTime(2024, 10, 16, 19, 49, 20, 591, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 12, 49, 20, 591, DateTimeKind.Utc).AddTicks(7990), new DateTime(2024, 10, 16, 12, 49, 20, 591, DateTimeKind.Utc).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 12, 49, 20, 591, DateTimeKind.Utc).AddTicks(7987), new DateTime(2024, 10, 16, 12, 49, 20, 591, DateTimeKind.Utc).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 12, 49, 20, 591, DateTimeKind.Utc).AddTicks(7981), new DateTime(2024, 10, 16, 12, 49, 20, 591, DateTimeKind.Utc).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 49, 20, 591, DateTimeKind.Local).AddTicks(7752), new DateTime(2024, 10, 16, 19, 49, 20, 591, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CohortId", "CreatedAt", "DeletedAt", "DepartmentId", "Email", "FullName", "IsDeleted", "IsVerify", "Password", "ProfileImageURL", "Role", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("38417752-8a61-429e-ae11-48beee51ce4d"), null, new DateTime(2024, 10, 16, 19, 49, 20, 591, DateTimeKind.Local).AddTicks(8118), null, -1, "manager@fpt.edu.vn", "John Doe", false, false, "123456", "https://placehold.co/600x400", "Manager", "Active", new DateTime(2024, 10, 16, 19, 49, 20, 591, DateTimeKind.Local).AddTicks(8120) },
                    { new Guid("6790713a-e476-4979-a3a4-63021381609a"), -1, new DateTime(2024, 10, 16, 19, 49, 20, 591, DateTimeKind.Local).AddTicks(8124), null, -1, "student@fpt.edu.vn", "John Doe", false, false, "123456", "https://placehold.co/600x400", "Student", "Active", new DateTime(2024, 10, 16, 19, 49, 20, 591, DateTimeKind.Local).AddTicks(8126) },
                    { new Guid("8f1504a7-ff71-4674-8f19-3d79e2c6e4a9"), null, new DateTime(2024, 10, 16, 19, 49, 20, 591, DateTimeKind.Local).AddTicks(8110), null, -1, "admin@fpt.edu.vn", "John Doe", false, false, "123456", "https://placehold.co/600x400", "Admin", "Active", new DateTime(2024, 10, 16, 19, 49, 20, 591, DateTimeKind.Local).AddTicks(8114) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("38417752-8a61-429e-ae11-48beee51ce4d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6790713a-e476-4979-a3a4-63021381609a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8f1504a7-ff71-4674-8f19-3d79e2c6e4a9"));

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "FaceDescriptors");

            migrationBuilder.AlterColumn<string>(
                name: "Descriptor",
                table: "FaceDescriptors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Cohort",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 18, 12, 24, 251, DateTimeKind.Local).AddTicks(1343), new DateTime(2024, 10, 16, 18, 12, 24, 251, DateTimeKind.Local).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 18, 12, 24, 251, DateTimeKind.Local).AddTicks(1260), new DateTime(2024, 10, 16, 18, 12, 24, 251, DateTimeKind.Local).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 11, 12, 24, 251, DateTimeKind.Utc).AddTicks(1146), new DateTime(2024, 10, 16, 11, 12, 24, 251, DateTimeKind.Utc).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 11, 12, 24, 251, DateTimeKind.Utc).AddTicks(1142), new DateTime(2024, 10, 16, 11, 12, 24, 251, DateTimeKind.Utc).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 11, 12, 24, 251, DateTimeKind.Utc).AddTicks(1133), new DateTime(2024, 10, 16, 11, 12, 24, 251, DateTimeKind.Utc).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 18, 12, 24, 251, DateTimeKind.Local).AddTicks(641), new DateTime(2024, 10, 16, 18, 12, 24, 251, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CohortId", "CreatedAt", "DeletedAt", "DepartmentId", "Email", "FullName", "IsDeleted", "IsVerify", "Password", "ProfileImageURL", "Role", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2ef14666-40c4-4a22-bdd7-4aa811696abc"), -1, new DateTime(2024, 10, 16, 18, 12, 24, 251, DateTimeKind.Local).AddTicks(1538), null, -1, "student@fpt.edu.vn", "John Doe", false, false, "123456", "https://placehold.co/600x400", "Student", "Active", new DateTime(2024, 10, 16, 18, 12, 24, 251, DateTimeKind.Local).AddTicks(1550) },
                    { new Guid("40fd9286-0995-4d49-90a1-6371db487206"), null, new DateTime(2024, 10, 16, 18, 12, 24, 251, DateTimeKind.Local).AddTicks(1525), null, -1, "manager@fpt.edu.vn", "John Doe", false, false, "123456", "https://placehold.co/600x400", "Manager", "Active", new DateTime(2024, 10, 16, 18, 12, 24, 251, DateTimeKind.Local).AddTicks(1529) },
                    { new Guid("9bdf04d1-75ab-400a-81fe-ab0d3399696b"), null, new DateTime(2024, 10, 16, 18, 12, 24, 251, DateTimeKind.Local).AddTicks(1506), null, -1, "admin@fpt.edu.vn", "John Doe", false, false, "123456", "https://placehold.co/600x400", "Admin", "Active", new DateTime(2024, 10, 16, 18, 12, 24, 251, DateTimeKind.Local).AddTicks(1515) }
                });
        }
    }
}
