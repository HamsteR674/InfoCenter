using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Db.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAndCreateTables2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Divisions_DivisionsId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DivisionsId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DivisionsId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "ChiefId",
                table: "Divisions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DivisionId",
                table: "Employees",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Divisions_ChiefId",
                table: "Divisions",
                column: "ChiefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Divisions_Employees_ChiefId",
                table: "Divisions",
                column: "ChiefId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Divisions_DivisionId",
                table: "Employees",
                column: "DivisionId",
                principalTable: "Divisions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Divisions_Employees_ChiefId",
                table: "Divisions");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Divisions_DivisionId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DivisionId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Divisions_ChiefId",
                table: "Divisions");

            migrationBuilder.DropColumn(
                name: "ChiefId",
                table: "Divisions");

            migrationBuilder.AddColumn<long>(
                name: "DivisionsId",
                table: "Employees",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DivisionsId",
                table: "Employees",
                column: "DivisionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Divisions_DivisionsId",
                table: "Employees",
                column: "DivisionsId",
                principalTable: "Divisions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
