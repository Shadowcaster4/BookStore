using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.DataAccess.Migrations
{
    public partial class editing_company : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Companies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Companies");
        }
    }
}
