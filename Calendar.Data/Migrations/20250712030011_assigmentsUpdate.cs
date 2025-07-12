using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calendar.Data.Migrations
{
    /// <inheritdoc />
    public partial class assigmentsUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assigment_Group_GroupId",
                schema: "Assigment",
                table: "Assigment");

            migrationBuilder.RenameColumn(
                name: "complete",
                schema: "Assigment",
                table: "AssigmentRecord",
                newName: "Complete");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                schema: "Assigment",
                table: "Assigment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Assigment_Group_GroupId",
                schema: "Assigment",
                table: "Assigment",
                column: "GroupId",
                principalSchema: "User",
                principalTable: "Group",
                principalColumn: "GroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assigment_Group_GroupId",
                schema: "Assigment",
                table: "Assigment");

            migrationBuilder.RenameColumn(
                name: "Complete",
                schema: "Assigment",
                table: "AssigmentRecord",
                newName: "complete");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                schema: "Assigment",
                table: "Assigment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Assigment_Group_GroupId",
                schema: "Assigment",
                table: "Assigment",
                column: "GroupId",
                principalSchema: "User",
                principalTable: "Group",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
