using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calendar.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTaskAndTaskHistory3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskHistory_Assigment_AssigmentId",
                schema: "Assigment",
                table: "TaskHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskHistory",
                schema: "Assigment",
                table: "TaskHistory");

            migrationBuilder.RenameTable(
                name: "TaskHistory",
                schema: "Assigment",
                newName: "AssigmentRecord",
                newSchema: "Assigment");

            migrationBuilder.RenameIndex(
                name: "IX_TaskHistory_AssigmentId",
                schema: "Assigment",
                table: "AssigmentRecord",
                newName: "IX_AssigmentRecord_AssigmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssigmentRecord",
                schema: "Assigment",
                table: "AssigmentRecord",
                column: "AssigmentRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssigmentRecord_Assigment_AssigmentId",
                schema: "Assigment",
                table: "AssigmentRecord",
                column: "AssigmentId",
                principalSchema: "Assigment",
                principalTable: "Assigment",
                principalColumn: "AssigmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssigmentRecord_Assigment_AssigmentId",
                schema: "Assigment",
                table: "AssigmentRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssigmentRecord",
                schema: "Assigment",
                table: "AssigmentRecord");

            migrationBuilder.RenameTable(
                name: "AssigmentRecord",
                schema: "Assigment",
                newName: "TaskHistory",
                newSchema: "Assigment");

            migrationBuilder.RenameIndex(
                name: "IX_AssigmentRecord_AssigmentId",
                schema: "Assigment",
                table: "TaskHistory",
                newName: "IX_TaskHistory_AssigmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskHistory",
                schema: "Assigment",
                table: "TaskHistory",
                column: "AssigmentRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskHistory_Assigment_AssigmentId",
                schema: "Assigment",
                table: "TaskHistory",
                column: "AssigmentId",
                principalSchema: "Assigment",
                principalTable: "Assigment",
                principalColumn: "AssigmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
