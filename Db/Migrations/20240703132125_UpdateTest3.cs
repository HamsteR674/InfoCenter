using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Db.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTest3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomStandInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    EmployeesId = table.Column<int>(type: "integer", nullable: false),
                    CreatorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomStandInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomStandInfo_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomStandEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InfoCentreId = table.Column<int>(type: "integer", nullable: false),
                    CustomStandInfoId = table.Column<int>(type: "integer", nullable: false),
                    EmployeesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomStandEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomStandEmployees_CustomStandInfo_CustomStandInfoId",
                        column: x => x.CustomStandInfoId,
                        principalTable: "CustomStandInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomStandEmployees_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomStandRights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InfoCenterId = table.Column<int>(type: "integer", nullable: false),
                    CustomStandInfoId = table.Column<int>(type: "integer", nullable: false),
                    EmployeesId = table.Column<int>(type: "integer", nullable: false),
                    Rights = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomStandRights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomStandRights_CustomStandInfo_CustomStandInfoId",
                        column: x => x.CustomStandInfoId,
                        principalTable: "CustomStandInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomStandEmployees_CustomStandInfoId",
                table: "CustomStandEmployees",
                column: "CustomStandInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomStandEmployees_EmployeesId",
                table: "CustomStandEmployees",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomStandInfo_EmployeesId",
                table: "CustomStandInfo",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomStandRights_CustomStandInfoId",
                table: "CustomStandRights",
                column: "CustomStandInfoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomStandEmployees");

            migrationBuilder.DropTable(
                name: "CustomStandRights");

            migrationBuilder.DropTable(
                name: "CustomStandInfo");
        }
    }
}
