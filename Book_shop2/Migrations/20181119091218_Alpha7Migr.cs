using Microsoft.EntityFrameworkCore.Migrations;

namespace Book_shop2.Migrations
{
    public partial class Alpha7Migr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "user_id",
                table: "Purchases");

            migrationBuilder.AddColumn<int>(
                name: "stuff_id",
                table: "Purchases",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "stuff_id",
                table: "Purchases");

            migrationBuilder.AddColumn<string>(
                name: "user_id",
                table: "Purchases",
                nullable: true);
        }
    }
}
