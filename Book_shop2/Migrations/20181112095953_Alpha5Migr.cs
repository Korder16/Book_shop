using Microsoft.EntityFrameworkCore.Migrations;

namespace Book_shop2.Migrations
{
    public partial class Alpha5Migr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order_id",
                table: "Clients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Order_id",
                table: "Clients",
                nullable: false,
                defaultValue: 0);
        }
    }
}
