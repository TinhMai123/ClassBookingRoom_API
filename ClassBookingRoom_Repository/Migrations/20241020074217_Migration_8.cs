using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassBookingRoom_Repository.Migrations
{
    /// <inheritdoc />
    public partial class Migration_8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FaceDescriptors_UserId",
                table: "FaceDescriptors");

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
                name: "CreatedAt",
                table: "BookingModifyHistory");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "BookingModifyHistory");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BookingModifyHistory");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "BookingModifyHistory");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VerifyToken",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Report",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Report",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Response",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Activity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Activity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_FaceDescriptors_UserId",
                table: "FaceDescriptors",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FaceDescriptors_UserId",
                table: "FaceDescriptors");

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

            migrationBuilder.DropColumn(
                name: "Note",
                table: "User");

            migrationBuilder.DropColumn(
                name: "VerifyToken",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "Response",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Activity");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Report",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Report",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "BookingModifyHistory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "BookingModifyHistory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BookingModifyHistory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "BookingModifyHistory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Activity",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.CreateIndex(
                name: "IX_FaceDescriptors_UserId",
                table: "FaceDescriptors",
                column: "UserId");
        }
    }
}
