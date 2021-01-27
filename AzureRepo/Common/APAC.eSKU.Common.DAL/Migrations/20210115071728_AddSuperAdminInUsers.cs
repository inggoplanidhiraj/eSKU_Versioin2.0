using Microsoft.EntityFrameworkCore.Migrations;

namespace APAC.eSKU.Common.DAL.Migrations
{
    public partial class AddSuperAdminInUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SuperAdmin",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SuperAdmin",
                table: "Users");
        }
    }
}
