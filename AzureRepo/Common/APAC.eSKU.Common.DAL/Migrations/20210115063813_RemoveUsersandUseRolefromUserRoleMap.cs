using Microsoft.EntityFrameworkCore.Migrations;

namespace APAC.eSKU.Common.DAL.Migrations
{
    public partial class RemoveUsersandUseRolefromUserRoleMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoleMap_UserRole_UserRoleID",
                table: "UserRoleMap");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoleMap_Users_UsersID",
                table: "UserRoleMap");

            migrationBuilder.DropIndex(
                name: "IX_UserRoleMap_UserRoleID",
                table: "UserRoleMap");

            migrationBuilder.DropIndex(
                name: "IX_UserRoleMap_UsersID",
                table: "UserRoleMap");

            migrationBuilder.DropColumn(
                name: "RoleID",
                table: "UserRoleMap");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "UserRoleMap");

            migrationBuilder.DropColumn(
                name: "UserRoleID",
                table: "UserRoleMap");

            migrationBuilder.DropColumn(
                name: "UsersID",
                table: "UserRoleMap");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleID",
                table: "UserRoleMap",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "UserRoleMap",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserRoleID",
                table: "UserRoleMap",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsersID",
                table: "UserRoleMap",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleMap_UserRoleID",
                table: "UserRoleMap",
                column: "UserRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleMap_UsersID",
                table: "UserRoleMap",
                column: "UsersID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoleMap_UserRole_UserRoleID",
                table: "UserRoleMap",
                column: "UserRoleID",
                principalTable: "UserRole",
                principalColumn: "UserRoleID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoleMap_Users_UsersID",
                table: "UserRoleMap",
                column: "UsersID",
                principalTable: "Users",
                principalColumn: "UsersID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
