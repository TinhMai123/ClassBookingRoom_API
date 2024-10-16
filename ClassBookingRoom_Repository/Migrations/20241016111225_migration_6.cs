using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassBookingRoom_Repository.Migrations
{
    /// <inheritdoc />
    public partial class migration_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Room",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "FaceDescriptors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Descriptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaceDescriptors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FaceDescriptors_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

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
                columns: new[] { "CreatedAt", "Picture", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 11, 12, 24, 251, DateTimeKind.Utc).AddTicks(1146), "", new DateTime(2024, 10, 16, 11, 12, 24, 251, DateTimeKind.Utc).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "Picture", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 11, 12, 24, 251, DateTimeKind.Utc).AddTicks(1142), "", new DateTime(2024, 10, 16, 11, 12, 24, 251, DateTimeKind.Utc).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "Picture", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 11, 12, 24, 251, DateTimeKind.Utc).AddTicks(1133), "", new DateTime(2024, 10, 16, 11, 12, 24, 251, DateTimeKind.Utc).AddTicks(1134) });

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

            migrationBuilder.CreateIndex(
                name: "IX_FaceDescriptors_UserId",
                table: "FaceDescriptors",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FaceDescriptors");

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

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Room");

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
    }
}
