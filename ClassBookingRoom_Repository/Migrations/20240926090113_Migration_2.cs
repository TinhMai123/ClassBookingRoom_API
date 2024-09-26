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
            migrationBuilder.DropForeignKey(
                name: "FK_RoomType_Department_DepartmentId",
                table: "RoomType");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("24a9ed53-3def-4582-bd46-872f50528e41"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("68c8cb26-8a82-48f2-b6eb-f0224aed11d3"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f44f3c52-00e4-4d90-a03c-6a0474eefa9f"));

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "RoomType",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cohort",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 1, 13, 179, DateTimeKind.Local).AddTicks(8211), new DateTime(2024, 9, 26, 16, 1, 13, 179, DateTimeKind.Local).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 1, 13, 179, DateTimeKind.Local).AddTicks(8191), new DateTime(2024, 9, 26, 16, 1, 13, 179, DateTimeKind.Local).AddTicks(8192) });

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "DepartmentId", "Name", "UpdatedAt" },
                values: new object[] { -1, new DateTime(2024, 9, 26, 16, 1, 13, 179, DateTimeKind.Local).AddTicks(8053), null, -1, "RoomT1", new DateTime(2024, 9, 26, 16, 1, 13, 179, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CohortId", "CreateAt", "DeleteAt", "DepartmentId", "Email", "FirstName", "LastName", "Password", "ProfileImageURL", "Role", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("37b8310f-38ca-479d-98b9-e15eaac6a561"), -1, new DateTime(2024, 9, 26, 16, 1, 13, 179, DateTimeKind.Local).AddTicks(8274), null, -1, "student@fpt.edu.vn", "John", "Doe", "123456", "https://placehold.co/600x400", "Student", "Active", new DateTime(2024, 9, 26, 16, 1, 13, 179, DateTimeKind.Local).AddTicks(8275) },
                    { new Guid("54d2f5c6-ad6f-4225-9826-97019485c7f9"), null, new DateTime(2024, 9, 26, 16, 1, 13, 179, DateTimeKind.Local).AddTicks(8270), null, -1, "manager@fpt.edu.vn", "John", "Doe", "123456", "https://placehold.co/600x400", "Manager", "Active", new DateTime(2024, 9, 26, 16, 1, 13, 179, DateTimeKind.Local).AddTicks(8271) },
                    { new Guid("af6656c5-322f-4ae5-be77-170b1dbd75b7"), null, new DateTime(2024, 9, 26, 16, 1, 13, 179, DateTimeKind.Local).AddTicks(8263), null, -1, "admin@fpt.edu.vn", "John", "Doe", "123456", "https://placehold.co/600x400", "Admin", "Active", new DateTime(2024, 9, 26, 16, 1, 13, 179, DateTimeKind.Local).AddTicks(8267) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_RoomType_Department_DepartmentId",
                table: "RoomType",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomType_Department_DepartmentId",
                table: "RoomType");

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("37b8310f-38ca-479d-98b9-e15eaac6a561"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("54d2f5c6-ad6f-4225-9826-97019485c7f9"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("af6656c5-322f-4ae5-be77-170b1dbd75b7"));

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "RoomType",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Cohort",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 26, 14, 58, 10, 716, DateTimeKind.Local).AddTicks(7436), new DateTime(2024, 9, 26, 14, 58, 10, 716, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 26, 14, 58, 10, 716, DateTimeKind.Local).AddTicks(7283), new DateTime(2024, 9, 26, 14, 58, 10, 716, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CohortId", "CreateAt", "DeleteAt", "DepartmentId", "Email", "FirstName", "LastName", "Password", "ProfileImageURL", "Role", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("24a9ed53-3def-4582-bd46-872f50528e41"), -1, new DateTime(2024, 9, 26, 14, 58, 10, 716, DateTimeKind.Local).AddTicks(7493), null, -1, "student@fpt.edu.vn", "John", "Doe", "123456", "https://placehold.co/600x400", "Student", "Active", new DateTime(2024, 9, 26, 14, 58, 10, 716, DateTimeKind.Local).AddTicks(7494) },
                    { new Guid("68c8cb26-8a82-48f2-b6eb-f0224aed11d3"), null, new DateTime(2024, 9, 26, 14, 58, 10, 716, DateTimeKind.Local).AddTicks(7489), null, -1, "manager@fpt.edu.vn", "John", "Doe", "123456", "https://placehold.co/600x400", "Manager", "Active", new DateTime(2024, 9, 26, 14, 58, 10, 716, DateTimeKind.Local).AddTicks(7491) },
                    { new Guid("f44f3c52-00e4-4d90-a03c-6a0474eefa9f"), null, new DateTime(2024, 9, 26, 14, 58, 10, 716, DateTimeKind.Local).AddTicks(7483), null, -1, "admin@fpt.edu.vn", "John", "Doe", "123456", "https://placehold.co/600x400", "Admin", "Active", new DateTime(2024, 9, 26, 14, 58, 10, 716, DateTimeKind.Local).AddTicks(7486) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_RoomType_Department_DepartmentId",
                table: "RoomType",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id");
        }
    }
}
