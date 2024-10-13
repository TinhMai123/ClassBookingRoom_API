using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassBookingRoom_Repository.Migrations
{
    /// <inheritdoc />
    public partial class migration_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "User",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteAt",
                table: "User",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "User",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "RoomType",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteAt",
                table: "RoomType",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "RoomType",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "RoomSlot",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteAt",
                table: "RoomSlot",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "RoomSlot",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Room",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteAt",
                table: "Room",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Room",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Report",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteAt",
                table: "Report",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Report",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Department",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteAt",
                table: "Department",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Department",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Cohort",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteAt",
                table: "Cohort",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Cohort",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "BookingModifyHistory",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteAt",
                table: "BookingModifyHistory",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "BookingModifyHistory",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Booking",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteAt",
                table: "Booking",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Booking",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Activity",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeleteAt",
                table: "Activity",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Activity",
                newName: "CreatedAt");

            migrationBuilder.UpdateData(
                table: "Cohort",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 17, 18, 39, 681, DateTimeKind.Local).AddTicks(2061), new DateTime(2024, 10, 13, 17, 18, 39, 681, DateTimeKind.Local).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 17, 18, 39, 681, DateTimeKind.Local).AddTicks(2042), new DateTime(2024, 10, 13, 17, 18, 39, 681, DateTimeKind.Local).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 10, 18, 39, 681, DateTimeKind.Utc).AddTicks(2016), new DateTime(2024, 10, 13, 10, 18, 39, 681, DateTimeKind.Utc).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 10, 18, 39, 681, DateTimeKind.Utc).AddTicks(2015), new DateTime(2024, 10, 13, 10, 18, 39, 681, DateTimeKind.Utc).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 10, 18, 39, 681, DateTimeKind.Utc).AddTicks(2010), new DateTime(2024, 10, 13, 10, 18, 39, 681, DateTimeKind.Utc).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 17, 18, 39, 681, DateTimeKind.Local).AddTicks(1859), new DateTime(2024, 10, 13, 17, 18, 39, 681, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CohortId", "CreatedAt", "DeletedAt", "DepartmentId", "Email", "FullName", "IsDeleted", "IsVerify", "Password", "ProfileImageURL", "Role", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1f28db2b-4b56-49cf-be94-6db2fc69723c"), null, new DateTime(2024, 10, 13, 17, 18, 39, 681, DateTimeKind.Local).AddTicks(2127), null, -1, "manager@fpt.edu.vn", "John Doe", false, false, "123456", "https://placehold.co/600x400", "Manager", "Active", new DateTime(2024, 10, 13, 17, 18, 39, 681, DateTimeKind.Local).AddTicks(2129) },
                    { new Guid("d263dcb1-9691-49c0-b040-d013442d4212"), -1, new DateTime(2024, 10, 13, 17, 18, 39, 681, DateTimeKind.Local).AddTicks(2132), null, -1, "student@fpt.edu.vn", "John Doe", false, false, "123456", "https://placehold.co/600x400", "Student", "Active", new DateTime(2024, 10, 13, 17, 18, 39, 681, DateTimeKind.Local).AddTicks(2133) },
                    { new Guid("f6a54505-88f6-4914-94ff-21dfcc4952ed"), null, new DateTime(2024, 10, 13, 17, 18, 39, 681, DateTimeKind.Local).AddTicks(2121), null, -1, "admin@fpt.edu.vn", "John Doe", false, false, "123456", "https://placehold.co/600x400", "Admin", "Active", new DateTime(2024, 10, 13, 17, 18, 39, 681, DateTimeKind.Local).AddTicks(2123) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1f28db2b-4b56-49cf-be94-6db2fc69723c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d263dcb1-9691-49c0-b040-d013442d4212"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f6a54505-88f6-4914-94ff-21dfcc4952ed"));

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "User",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "User",
                newName: "DeleteAt");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "User",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "RoomType",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "RoomType",
                newName: "DeleteAt");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "RoomType",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "RoomSlot",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "RoomSlot",
                newName: "DeleteAt");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "RoomSlot",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Room",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "Room",
                newName: "DeleteAt");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Room",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Report",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "Report",
                newName: "DeleteAt");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Report",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Department",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "Department",
                newName: "DeleteAt");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Department",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Cohort",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "Cohort",
                newName: "DeleteAt");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Cohort",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "BookingModifyHistory",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "BookingModifyHistory",
                newName: "DeleteAt");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "BookingModifyHistory",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Booking",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "Booking",
                newName: "DeleteAt");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Booking",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Activity",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "Activity",
                newName: "DeleteAt");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Activity",
                newName: "CreateAt");

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
    }
}
