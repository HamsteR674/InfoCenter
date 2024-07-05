using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InteractionDb.Migrations
{
    /// <inheritdoc />
    public partial class UpdateName2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EployeeId",
                table: "TakenTasks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EployeeId",
                table: "TakenTasks",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
