using Microsoft.EntityFrameworkCore.Migrations;

namespace Book_shop2.Migrations
{
    public partial class Alpha6Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "user_id",
                table: "Purchases",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "user_id",
                table: "Purchases");
        }
    }
}
