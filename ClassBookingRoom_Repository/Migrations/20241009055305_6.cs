using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassBookingRoom_Repository.Migrations
{
    /// <inheritdoc />
    public partial class _6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "User",
                newName: "FullName");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "User",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
