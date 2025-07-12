using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calendar.Data.Migrations
{
    /// <inheritdoc />
    public partial class assigmentsUpdat2e : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeekDays_Assigment_AssigmentId",
                schema: "catalogs",
                table: "WeekDays");

            migrationBuilder.DropIndex(
                name: "IX_WeekDays_AssigmentId",
                schema: "catalogs",
                table: "WeekDays");

            migrationBuilder.DropColumn(
                name: "AssigmentId",
                schema: "catalogs",
                table: "WeekDays");

            migrationBuilder.CreateTable(
                name: "AssigmentWeekDay",
                columns: table => new
                {
                    AssigmentsAssigmentId = table.Column<int>(type: "int", nullable: false),
                    WeekDaysWeekDayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssigmentWeekDay", x => new { x.AssigmentsAssigmentId, x.WeekDaysWeekDayId });
                    table.ForeignKey(
                        name: "FK_AssigmentWeekDay_Assigment_AssigmentsAssigmentId",
                        column: x => x.AssigmentsAssigmentId,
                        principalSchema: "Assigment",
                        principalTable: "Assigment",
                        principalColumn: "AssigmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssigmentWeekDay_WeekDays_WeekDaysWeekDayId",
                        column: x => x.WeekDaysWeekDayId,
                        principalSchema: "catalogs",
                        principalTable: "WeekDays",
                        principalColumn: "WeekDayId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssigmentWeekDay_WeekDaysWeekDayId",
                table: "AssigmentWeekDay",
                column: "WeekDaysWeekDayId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssigmentWeekDay");

            migrationBuilder.AddColumn<int>(
                name: "AssigmentId",
                schema: "catalogs",
                table: "WeekDays",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WeekDays_AssigmentId",
                schema: "catalogs",
                table: "WeekDays",
                column: "AssigmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_WeekDays_Assigment_AssigmentId",
                schema: "catalogs",
                table: "WeekDays",
                column: "AssigmentId",
                principalSchema: "Assigment",
                principalTable: "Assigment",
                principalColumn: "AssigmentId");
        }
    }
}
