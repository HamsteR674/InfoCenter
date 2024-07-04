using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InteractionDb.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MirrorParameters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InfoCenterUpdateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdateTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MirrorParameters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemInfo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemStateInfo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CheckDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Result = table.Column<bool>(type: "boolean", nullable: false),
                    ErrorList = table.Column<string>(type: "text", nullable: false),
                    SystemInfoId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemStateInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemStateInfo_SystemInfo_SystemInfoId",
                        column: x => x.SystemInfoId,
                        principalTable: "SystemInfo",
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
                });

            migrationBuilder.CreateTable(
                name: "CustomStandInfos",
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
                    table.PrimaryKey("PK_CustomStandInfos", x => x.Id);
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
                        name: "FK_CustomStandRights_CustomStandInfos_CustomStandInfoId",
                        column: x => x.CustomStandInfoId,
                        principalTable: "CustomStandInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ParentDivCode = table.Column<int>(type: "integer", nullable: true),
                    ParentId = table.Column<long>(type: "bigint", nullable: false),
                    ChiefId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Divisions_Divisions_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    IsFired = table.Column<bool>(type: "boolean", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    DivisionId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Divisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PandingTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ServiceCallId = table.Column<int>(type: "integer", nullable: false),
                    ServiceCallTitle = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    EployeeId = table.Column<int>(type: "integer", nullable: false),
                    EmployeesId = table.Column<int>(type: "integer", nullable: false),
                    MirrorParametersId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PandingTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PandingTasks_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PandingTasks_MirrorParameters_MirrorParametersId",
                        column: x => x.MirrorParametersId,
                        principalTable: "MirrorParameters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SessionLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeesId = table.Column<int>(type: "integer", nullable: false),
                    ErrorList = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SessionLog_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeesId = table.Column<int>(type: "integer", nullable: false),
                    JsonSettings = table.Column<string>(type: "json", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.id);
                    table.ForeignKey(
                        name: "FK_Settings_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TakenTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tittle = table.Column<string>(type: "text", nullable: false),
                    ExpirationData = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Service = table.Column<string>(type: "text", nullable: false),
                    ServiceComponent = table.Column<string>(type: "text", nullable: false),
                    IsProjectTask = table.Column<bool>(type: "boolean", nullable: false),
                    ServiceCallId = table.Column<int>(type: "integer", nullable: false),
                    EployeeId = table.Column<int>(type: "integer", nullable: false),
                    EmployeesId = table.Column<int>(type: "integer", nullable: false),
                    MirrorParametersId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakenTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TakenTasks_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TakenTasks_MirrorParameters_MirrorParametersId",
                        column: x => x.MirrorParametersId,
                        principalTable: "MirrorParameters",
                        principalColumn: "Id");
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
                name: "IX_CustomStandInfos_EmployeesId",
                table: "CustomStandInfos",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomStandRights_CustomStandInfoId",
                table: "CustomStandRights",
                column: "CustomStandInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Divisions_ChiefId",
                table: "Divisions",
                column: "ChiefId");

            migrationBuilder.CreateIndex(
                name: "IX_Divisions_ParentId",
                table: "Divisions",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DivisionId",
                table: "Employees",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_PandingTasks_EmployeesId",
                table: "PandingTasks",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_PandingTasks_MirrorParametersId",
                table: "PandingTasks",
                column: "MirrorParametersId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionLog_EmployeesId",
                table: "SessionLog",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_Settings_EmployeesId",
                table: "Settings",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemStateInfo_CheckDateTime",
                table: "SystemStateInfo",
                column: "CheckDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_SystemStateInfo_SystemInfoId",
                table: "SystemStateInfo",
                column: "SystemInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_TakenTasks_EmployeesId",
                table: "TakenTasks",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_TakenTasks_MirrorParametersId",
                table: "TakenTasks",
                column: "MirrorParametersId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomStandEmployees_CustomStandInfos_CustomStandInfoId",
                table: "CustomStandEmployees",
                column: "CustomStandInfoId",
                principalTable: "CustomStandInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomStandEmployees_Employees_EmployeesId",
                table: "CustomStandEmployees",
                column: "EmployeesId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomStandInfos_Employees_EmployeesId",
                table: "CustomStandInfos",
                column: "EmployeesId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Divisions_Employees_ChiefId",
                table: "Divisions",
                column: "ChiefId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Divisions_Employees_ChiefId",
                table: "Divisions");

            migrationBuilder.DropTable(
                name: "CustomStandEmployees");

            migrationBuilder.DropTable(
                name: "CustomStandRights");

            migrationBuilder.DropTable(
                name: "PandingTasks");

            migrationBuilder.DropTable(
                name: "SessionLog");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "SystemStateInfo");

            migrationBuilder.DropTable(
                name: "TakenTasks");

            migrationBuilder.DropTable(
                name: "CustomStandInfos");

            migrationBuilder.DropTable(
                name: "SystemInfo");

            migrationBuilder.DropTable(
                name: "MirrorParameters");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Divisions");
        }
    }
}
