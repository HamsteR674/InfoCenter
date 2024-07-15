using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InteractionDb.Migrations
{
    /// <inheritdoc />
    public partial class Test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PandingTasks_Employees_EmployeesId",
                table: "PandingTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_PandingTasks_MirrorParameters_UpdateTimeId",
                table: "PandingTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PandingTasks",
                table: "PandingTasks");

            migrationBuilder.RenameTable(
                name: "PandingTasks",
                newName: "PendingTasks");

            migrationBuilder.RenameIndex(
                name: "IX_PandingTasks_UpdateTimeId",
                table: "PendingTasks",
                newName: "IX_PendingTasks_UpdateTimeId");

            migrationBuilder.RenameIndex(
                name: "IX_PandingTasks_EmployeesId",
                table: "PendingTasks",
                newName: "IX_PendingTasks_EmployeesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PendingTasks",
                table: "PendingTasks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PendingTasks_Employees_EmployeesId",
                table: "PendingTasks",
                column: "EmployeesId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PendingTasks_MirrorParameters_UpdateTimeId",
                table: "PendingTasks",
                column: "UpdateTimeId",
                principalTable: "MirrorParameters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PendingTasks_Employees_EmployeesId",
                table: "PendingTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_PendingTasks_MirrorParameters_UpdateTimeId",
                table: "PendingTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PendingTasks",
                table: "PendingTasks");

            migrationBuilder.RenameTable(
                name: "PendingTasks",
                newName: "PandingTasks");

            migrationBuilder.RenameIndex(
                name: "IX_PendingTasks_UpdateTimeId",
                table: "PandingTasks",
                newName: "IX_PandingTasks_UpdateTimeId");

            migrationBuilder.RenameIndex(
                name: "IX_PendingTasks_EmployeesId",
                table: "PandingTasks",
                newName: "IX_PandingTasks_EmployeesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PandingTasks",
                table: "PandingTasks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PandingTasks_Employees_EmployeesId",
                table: "PandingTasks",
                column: "EmployeesId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PandingTasks_MirrorParameters_UpdateTimeId",
                table: "PandingTasks",
                column: "UpdateTimeId",
                principalTable: "MirrorParameters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
