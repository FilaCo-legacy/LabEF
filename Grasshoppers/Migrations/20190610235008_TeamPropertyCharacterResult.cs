using Microsoft.EntityFrameworkCore.Migrations;

namespace Grasshoppers.Migrations
{
    public partial class TeamPropertyCharacterResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Team",
                table: "CharactersResults",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Team",
                table: "CharactersResults");
        }
    }
}
