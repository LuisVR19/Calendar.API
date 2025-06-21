using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calendar.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTaskAndTaskHistory2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Assigment",
                schema: "Task",
                newName: "Assigment",
                newSchema: "Assigment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Task");

            migrationBuilder.RenameTable(
                name: "Assigment",
                schema: "Assigment",
                newName: "Assigment",
                newSchema: "Task");
        }
    }
}
