using Microsoft.EntityFrameworkCore.Migrations;

namespace Book_shop2.Migrations
{
    public partial class Alpha2Migr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Activity",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activity",
                table: "Users");
        }
    }
}
