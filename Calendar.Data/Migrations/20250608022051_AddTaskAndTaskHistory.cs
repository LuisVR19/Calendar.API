using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calendar.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTaskAndTaskHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Task");

            migrationBuilder.EnsureSchema(
                name: "Assigment");

            migrationBuilder.AddColumn<int>(
                name: "AssigmentId",
                schema: "catalogs",
                table: "WeekDays",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Assigment",
                schema: "Task",
                columns: table => new
                {
                    AssigmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    PriorityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assigment", x => x.AssigmentId);
                    table.ForeignKey(
                        name: "FK_Assigment_Group_GroupId",
                        column: x => x.GroupId,
                        principalSchema: "User",
                        principalTable: "Group",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assigment_Priority_PriorityId",
                        column: x => x.PriorityId,
                        principalSchema: "catalogs",
                        principalTable: "Priority",
                        principalColumn: "PriorityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assigment_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "User",
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskHistory",
                schema: "Assigment",
                columns: table => new
                {
                    AssigmentRecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    complete = table.Column<bool>(type: "bit", nullable: false),
                    AssigmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskHistory", x => x.AssigmentRecordId);
                    table.ForeignKey(
                        name: "FK_TaskHistory_Assigment_AssigmentId",
                        column: x => x.AssigmentId,
                        principalSchema: "Task",
                        principalTable: "Assigment",
                        principalColumn: "AssigmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeekDays_AssigmentId",
                schema: "catalogs",
                table: "WeekDays",
                column: "AssigmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Assigment_GroupId",
                schema: "Task",
                table: "Assigment",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Assigment_PriorityId",
                schema: "Task",
                table: "Assigment",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Assigment_UserId",
                schema: "Task",
                table: "Assigment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskHistory_AssigmentId",
                schema: "Assigment",
                table: "TaskHistory",
                column: "AssigmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_WeekDays_Assigment_AssigmentId",
                schema: "catalogs",
                table: "WeekDays",
                column: "AssigmentId",
                principalSchema: "Task",
                principalTable: "Assigment",
                principalColumn: "AssigmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeekDays_Assigment_AssigmentId",
                schema: "catalogs",
                table: "WeekDays");

            migrationBuilder.DropTable(
                name: "TaskHistory",
                schema: "Assigment");

            migrationBuilder.DropTable(
                name: "Assigment",
                schema: "Task");

            migrationBuilder.DropIndex(
                name: "IX_WeekDays_AssigmentId",
                schema: "catalogs",
                table: "WeekDays");

            migrationBuilder.DropColumn(
                name: "AssigmentId",
                schema: "catalogs",
                table: "WeekDays");
        }
    }
}
