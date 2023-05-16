using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeskUniverse_Backend.Migrations
{
    /// <inheritdoc />
    public partial class TokenUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Tokens",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Tokens");
        }
    }
}
