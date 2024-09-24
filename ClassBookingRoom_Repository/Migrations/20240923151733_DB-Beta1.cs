using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassBookingRoom_Repository.Migrations
{
    /// <inheritdoc />
    public partial class DBBeta1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookingActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingId = table.Column<int>(type: "int", nullable: true),
                    ActivityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingActivities_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookingActivities_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookingDepartments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingDepartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingDepartments_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookingDepartments_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingActivities_ActivityId",
                table: "BookingActivities",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingActivities_BookingId",
                table: "BookingActivities",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDepartments_BookingId",
                table: "BookingDepartments",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDepartments_DepartmentId",
                table: "BookingDepartments",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingActivities");

            migrationBuilder.DropTable(
                name: "BookingDepartments");
        }
    }
}
