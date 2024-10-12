using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassBookingRoom_Repository.Migrations
{
    /// <inheritdoc />
    public partial class model_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Response",
                table: "Report",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cohort",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 10, 36, 8, 361, DateTimeKind.Local).AddTicks(5903), new DateTime(2024, 10, 12, 10, 36, 8, 361, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 10, 36, 8, 361, DateTimeKind.Local).AddTicks(5853), new DateTime(2024, 10, 12, 10, 36, 8, 361, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 3, 36, 8, 361, DateTimeKind.Utc).AddTicks(5790), new DateTime(2024, 10, 12, 3, 36, 8, 361, DateTimeKind.Utc).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 3, 36, 8, 361, DateTimeKind.Utc).AddTicks(5785), new DateTime(2024, 10, 12, 3, 36, 8, 361, DateTimeKind.Utc).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 3, 36, 8, 361, DateTimeKind.Utc).AddTicks(5776), new DateTime(2024, 10, 12, 3, 36, 8, 361, DateTimeKind.Utc).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 10, 36, 8, 361, DateTimeKind.Local).AddTicks(5298), new DateTime(2024, 10, 12, 10, 36, 8, 361, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CohortId", "CreateAt", "DeleteAt", "DepartmentId", "Email", "FullName", "IsVerify", "Password", "ProfileImageURL", "Role", "Status", "UpdatedAt", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("41790b83-bdd7-432f-be10-e9343fdf46db"), null, new DateTime(2024, 10, 12, 10, 36, 8, 361, DateTimeKind.Local).AddTicks(6036), null, -1, "manager@fpt.edu.vn", "John Doe", false, "123456", "https://placehold.co/600x400", "Manager", "Active", new DateTime(2024, 10, 12, 10, 36, 8, 361, DateTimeKind.Local).AddTicks(6039), false },
                    { new Guid("788eb7e9-503a-4997-9539-c0c91aa86a95"), null, new DateTime(2024, 10, 12, 10, 36, 8, 361, DateTimeKind.Local).AddTicks(6017), null, -1, "admin@fpt.edu.vn", "John Doe", false, "123456", "https://placehold.co/600x400", "Admin", "Active", new DateTime(2024, 10, 12, 10, 36, 8, 361, DateTimeKind.Local).AddTicks(6027), false },
                    { new Guid("e5f4dacd-e75b-49b8-ade6-adf690bf1f54"), -1, new DateTime(2024, 10, 12, 10, 36, 8, 361, DateTimeKind.Local).AddTicks(6047), null, -1, "student@fpt.edu.vn", "John Doe", false, "123456", "https://placehold.co/600x400", "Student", "Active", new DateTime(2024, 10, 12, 10, 36, 8, 361, DateTimeKind.Local).AddTicks(6050), false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("41790b83-bdd7-432f-be10-e9343fdf46db"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("788eb7e9-503a-4997-9539-c0c91aa86a95"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e5f4dacd-e75b-49b8-ade6-adf690bf1f54"));

            migrationBuilder.DropColumn(
                name: "Response",
                table: "Report");

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
    }
}
