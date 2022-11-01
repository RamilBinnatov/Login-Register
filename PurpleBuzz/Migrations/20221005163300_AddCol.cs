using Microsoft.EntityFrameworkCore.Migrations;

namespace PurpleBuzz.Migrations
{
    public partial class AddCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "H",
                table: "Works",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "P",
                table: "Works",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "H",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "P",
                table: "Works");
        }
    }
}
