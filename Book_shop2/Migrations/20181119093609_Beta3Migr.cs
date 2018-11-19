using Microsoft.EntityFrameworkCore.Migrations;

namespace Book_shop2.Migrations
{
    public partial class Beta3Migr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Purchases",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Purchases");
        }
    }
}
