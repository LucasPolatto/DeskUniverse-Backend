using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeskUniverse_Backend.Migrations
{
    /// <inheritdoc />
    public partial class CharacterCHA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CHA",
                table: "Characters",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CHA",
                table: "Characters");
        }
    }
}
