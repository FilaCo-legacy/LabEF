using Microsoft.EntityFrameworkCore.Migrations;

namespace Grasshoppers.Migrations
{
    public partial class RenamedProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Characters_PlayerId",
                table: "Inventories");

            migrationBuilder.RenameColumn(
                name: "RequiredPlayersNumber",
                table: "Missions",
                newName: "RequiredParticipatorsNumber");

            migrationBuilder.RenameColumn(
                name: "StunnedPlayers",
                table: "CharactersResults",
                newName: "StunnedCharacters");

            migrationBuilder.AlterColumn<int>(
                name: "PlayerId",
                table: "Inventories",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CharacterId",
                table: "Inventories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Characters_PlayerId",
                table: "Inventories",
                column: "PlayerId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Characters_PlayerId",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "Inventories");

            migrationBuilder.RenameColumn(
                name: "RequiredParticipatorsNumber",
                table: "Missions",
                newName: "RequiredPlayersNumber");

            migrationBuilder.RenameColumn(
                name: "StunnedCharacters",
                table: "CharactersResults",
                newName: "StunnedPlayers");

            migrationBuilder.AlterColumn<int>(
                name: "PlayerId",
                table: "Inventories",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Characters_PlayerId",
                table: "Inventories",
                column: "PlayerId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
