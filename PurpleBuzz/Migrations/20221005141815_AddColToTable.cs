using Microsoft.EntityFrameworkCore.Migrations;

namespace PurpleBuzz.Migrations
{
    public partial class AddColToTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "Sliders");

            migrationBuilder.AddColumn<string>(
                name: "A",
                table: "Sliders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "H1",
                table: "Sliders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "P",
                table: "Sliders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "A",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "H1",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "P",
                table: "Sliders");

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
