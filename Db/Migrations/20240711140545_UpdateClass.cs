using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InteractionDb.Migrations
{
    /// <inheritdoc />
    public partial class UpdateClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Divisions_Divisions_ParentId",
                table: "Divisions");

            migrationBuilder.DropForeignKey(
                name: "FK_TakenTasks_MirrorParameters_MirrorParametersId",
                table: "TakenTasks");

            migrationBuilder.DropIndex(
                name: "IX_TakenTasks_MirrorParametersId",
                table: "TakenTasks");

            migrationBuilder.DropColumn(
                name: "MirrorParametersId",
                table: "TakenTasks");

            migrationBuilder.AddColumn<int>(
                name: "UpdateTimeId",
                table: "TakenTasks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<long>(
                name: "ParentId",
                table: "Divisions",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_TakenTasks_UpdateTimeId",
                table: "TakenTasks",
                column: "UpdateTimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Divisions_Divisions_ParentId",
                table: "Divisions",
                column: "ParentId",
                principalTable: "Divisions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TakenTasks_MirrorParameters_UpdateTimeId",
                table: "TakenTasks",
                column: "UpdateTimeId",
                principalTable: "MirrorParameters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Divisions_Divisions_ParentId",
                table: "Divisions");

            migrationBuilder.DropForeignKey(
                name: "FK_TakenTasks_MirrorParameters_UpdateTimeId",
                table: "TakenTasks");

            migrationBuilder.DropIndex(
                name: "IX_TakenTasks_UpdateTimeId",
                table: "TakenTasks");

            migrationBuilder.DropColumn(
                name: "UpdateTimeId",
                table: "TakenTasks");

            migrationBuilder.AddColumn<int>(
                name: "MirrorParametersId",
                table: "TakenTasks",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ParentId",
                table: "Divisions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TakenTasks_MirrorParametersId",
                table: "TakenTasks",
                column: "MirrorParametersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Divisions_Divisions_ParentId",
                table: "Divisions",
                column: "ParentId",
                principalTable: "Divisions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TakenTasks_MirrorParameters_MirrorParametersId",
                table: "TakenTasks",
                column: "MirrorParametersId",
                principalTable: "MirrorParameters",
                principalColumn: "Id");
        }
    }
}
