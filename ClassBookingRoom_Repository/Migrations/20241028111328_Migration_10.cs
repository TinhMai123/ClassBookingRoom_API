using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassBookingRoom_Repository.Migrations
{
    /// <inheritdoc />
    public partial class Migration_10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "PushToken",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cohort",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 28, 18, 13, 26, 975, DateTimeKind.Local).AddTicks(1415), new DateTime(2024, 10, 28, 18, 13, 26, 975, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 28, 18, 13, 26, 975, DateTimeKind.Local).AddTicks(1398), new DateTime(2024, 10, 28, 18, 13, 26, 975, DateTimeKind.Local).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 28, 11, 13, 26, 975, DateTimeKind.Utc).AddTicks(1377), new DateTime(2024, 10, 28, 11, 13, 26, 975, DateTimeKind.Utc).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 28, 11, 13, 26, 975, DateTimeKind.Utc).AddTicks(1375), new DateTime(2024, 10, 28, 11, 13, 26, 975, DateTimeKind.Utc).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 28, 11, 13, 26, 975, DateTimeKind.Utc).AddTicks(1371), new DateTime(2024, 10, 28, 11, 13, 26, 975, DateTimeKind.Utc).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 28, 18, 13, 26, 975, DateTimeKind.Local).AddTicks(1221), new DateTime(2024, 10, 28, 18, 13, 26, 975, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CohortId", "CreatedAt", "DeletedAt", "DepartmentId", "Email", "FullName", "IsDeleted", "IsVerify", "Note", "Password", "ProfileImageURL", "PushToken", "Role", "Status", "UpdatedAt", "VerifyToken" },
                values: new object[,]
                {
                    { new Guid("b74fbcd2-8e3b-4bcc-8984-7c18810a369d"), -1, new DateTime(2024, 10, 28, 18, 13, 26, 975, DateTimeKind.Local).AddTicks(1562), null, -1, "student@fpt.edu.vn", "John Doe", false, false, null, "123456", "https://placehold.co/600x400", null, "Student", "Active", new DateTime(2024, 10, 28, 18, 13, 26, 975, DateTimeKind.Local).AddTicks(1564), null },
                    { new Guid("e28505ad-eba7-4c83-a260-fb9dc24060c1"), null, new DateTime(2024, 10, 28, 18, 13, 26, 975, DateTimeKind.Local).AddTicks(1558), null, -1, "manager@fpt.edu.vn", "John Doe", false, false, null, "123456", "https://placehold.co/600x400", null, "Manager", "Active", new DateTime(2024, 10, 28, 18, 13, 26, 975, DateTimeKind.Local).AddTicks(1560), null },
                    { new Guid("e30ee5b6-0c2e-430c-ae69-851c92032f2f"), null, new DateTime(2024, 10, 28, 18, 13, 26, 975, DateTimeKind.Local).AddTicks(1553), null, -1, "admin@fpt.edu.vn", "John Doe", false, false, null, "123456", "https://placehold.co/600x400", null, "Admin", "Active", new DateTime(2024, 10, 28, 18, 13, 26, 975, DateTimeKind.Local).AddTicks(1555), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b74fbcd2-8e3b-4bcc-8984-7c18810a369d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e28505ad-eba7-4c83-a260-fb9dc24060c1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e30ee5b6-0c2e-430c-ae69-851c92032f2f"));

            migrationBuilder.DropColumn(
                name: "PushToken",
                table: "User");

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
    }
}
