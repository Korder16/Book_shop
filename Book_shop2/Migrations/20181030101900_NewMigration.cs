using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Book_shop2.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "author",
                table: "Books",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "genre",
                table: "Books",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "year",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    book_id = table.Column<int>(nullable: false),
                    price = table.Column<int>(nullable: false),
                    count = table.Column<int>(nullable: false),
                    cost = table.Column<int>(nullable: false),
                    year = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.DropColumn(
                name: "author",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "genre",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "price",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "year",
                table: "Books");
        }
    }
}
