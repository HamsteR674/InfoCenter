using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InteractionDb.Migrations
{
    /// <inheritdoc />
    public partial class UpdateName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomStandEmployees_CustomStandInfos_CustomStandInfoId",
                table: "CustomStandEmployees");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomStandInfos_Employees_EmployeesId",
                table: "CustomStandInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomStandRights_CustomStandInfos_CustomStandInfoId",
                table: "CustomStandRights");

            migrationBuilder.DropForeignKey(
                name: "FK_PandingTasks_MirrorParameters_MirrorParametersId",
                table: "PandingTasks");

            migrationBuilder.DropIndex(
                name: "IX_PandingTasks_MirrorParametersId",
                table: "PandingTasks");

            migrationBuilder.DropIndex(
                name: "IX_CustomStandRights_CustomStandInfoId",
                table: "CustomStandRights");

            migrationBuilder.DropIndex(
                name: "IX_CustomStandEmployees_CustomStandInfoId",
                table: "CustomStandEmployees");

            migrationBuilder.DropColumn(
                name: "MirrorParametersId",
                table: "PandingTasks");

            migrationBuilder.DropColumn(
                name: "CustomStandInfoId",
                table: "CustomStandRights");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "CustomStandInfos");

            migrationBuilder.DropColumn(
                name: "CustomStandInfoId",
                table: "CustomStandEmployees");

            migrationBuilder.RenameColumn(
                name: "ErrorList",
                table: "SystemStateInfo",
                newName: "ErrorLis");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "SystemInfo",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Settings",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EployeeId",
                table: "PandingTasks",
                newName: "UpdateTimeId");

            migrationBuilder.RenameColumn(
                name: "UpdateTimestamp",
                table: "MirrorParameters",
                newName: "UpdateTimestam");

            migrationBuilder.RenameColumn(
                name: "InfoCenterId",
                table: "CustomStandRights",
                newName: "InfoCenterIdId");

            migrationBuilder.RenameColumn(
                name: "EmployeesId",
                table: "CustomStandRights",
                newName: "EmployeesI");

            migrationBuilder.RenameColumn(
                name: "EmployeesId",
                table: "CustomStandInfos",
                newName: "CreatorIdId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomStandInfos_EmployeesId",
                table: "CustomStandInfos",
                newName: "IX_CustomStandInfos_CreatorIdId");

            migrationBuilder.CreateIndex(
                name: "IX_PandingTasks_UpdateTimeId",
                table: "PandingTasks",
                column: "UpdateTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomStandRights_InfoCenterIdId",
                table: "CustomStandRights",
                column: "InfoCenterIdId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomStandEmployees_InfoCentreId",
                table: "CustomStandEmployees",
                column: "InfoCentreId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomStandEmployees_CustomStandInfos_InfoCentreId",
                table: "CustomStandEmployees",
                column: "InfoCentreId",
                principalTable: "CustomStandInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomStandInfos_Employees_CreatorIdId",
                table: "CustomStandInfos",
                column: "CreatorIdId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomStandRights_CustomStandInfos_InfoCenterIdId",
                table: "CustomStandRights",
                column: "InfoCenterIdId",
                principalTable: "CustomStandInfos",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomStandEmployees_CustomStandInfos_InfoCentreId",
                table: "CustomStandEmployees");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomStandInfos_Employees_CreatorIdId",
                table: "CustomStandInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomStandRights_CustomStandInfos_InfoCenterIdId",
                table: "CustomStandRights");

            migrationBuilder.DropForeignKey(
                name: "FK_PandingTasks_MirrorParameters_UpdateTimeId",
                table: "PandingTasks");

            migrationBuilder.DropIndex(
                name: "IX_PandingTasks_UpdateTimeId",
                table: "PandingTasks");

            migrationBuilder.DropIndex(
                name: "IX_CustomStandRights_InfoCenterIdId",
                table: "CustomStandRights");

            migrationBuilder.DropIndex(
                name: "IX_CustomStandEmployees_InfoCentreId",
                table: "CustomStandEmployees");

            migrationBuilder.RenameColumn(
                name: "ErrorLis",
                table: "SystemStateInfo",
                newName: "ErrorList");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "SystemInfo",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Settings",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdateTimeId",
                table: "PandingTasks",
                newName: "EployeeId");

            migrationBuilder.RenameColumn(
                name: "UpdateTimestam",
                table: "MirrorParameters",
                newName: "UpdateTimestamp");

            migrationBuilder.RenameColumn(
                name: "InfoCenterIdId",
                table: "CustomStandRights",
                newName: "InfoCenterId");

            migrationBuilder.RenameColumn(
                name: "EmployeesI",
                table: "CustomStandRights",
                newName: "EmployeesId");

            migrationBuilder.RenameColumn(
                name: "CreatorIdId",
                table: "CustomStandInfos",
                newName: "EmployeesId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomStandInfos_CreatorIdId",
                table: "CustomStandInfos",
                newName: "IX_CustomStandInfos_EmployeesId");

            migrationBuilder.AddColumn<int>(
                name: "MirrorParametersId",
                table: "PandingTasks",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomStandInfoId",
                table: "CustomStandRights",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "CustomStandInfos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomStandInfoId",
                table: "CustomStandEmployees",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PandingTasks_MirrorParametersId",
                table: "PandingTasks",
                column: "MirrorParametersId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomStandRights_CustomStandInfoId",
                table: "CustomStandRights",
                column: "CustomStandInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomStandEmployees_CustomStandInfoId",
                table: "CustomStandEmployees",
                column: "CustomStandInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomStandEmployees_CustomStandInfos_CustomStandInfoId",
                table: "CustomStandEmployees",
                column: "CustomStandInfoId",
                principalTable: "CustomStandInfos",
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
                name: "FK_CustomStandRights_CustomStandInfos_CustomStandInfoId",
                table: "CustomStandRights",
                column: "CustomStandInfoId",
                principalTable: "CustomStandInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PandingTasks_MirrorParameters_MirrorParametersId",
                table: "PandingTasks",
                column: "MirrorParametersId",
                principalTable: "MirrorParameters",
                principalColumn: "Id");
        }
    }
}
