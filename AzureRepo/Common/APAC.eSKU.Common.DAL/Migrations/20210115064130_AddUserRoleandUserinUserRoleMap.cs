using Microsoft.EntityFrameworkCore.Migrations;

namespace APAC.eSKU.Common.DAL.Migrations
{
    public partial class AddUserRoleandUserinUserRoleMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserRoleID",
                table: "UserRoleMap",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsersID",
                table: "UserRoleMap",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                principalColumn: "UserRoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoleMap_Users_UsersID",
                table: "UserRoleMap",
                column: "UsersID",
                principalTable: "Users",
                principalColumn: "UsersID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "UserRoleID",
                table: "UserRoleMap");

            migrationBuilder.DropColumn(
                name: "UsersID",
                table: "UserRoleMap");
        }
    }
}
