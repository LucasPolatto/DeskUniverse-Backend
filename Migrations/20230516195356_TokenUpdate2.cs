using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeskUniverse_Backend.Migrations
{
    /// <inheritdoc />
    public partial class TokenUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CharacterId",
                table: "Tokens",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "Tokens");
        }
    }
}
