using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeskUniverse_Backend.Migrations
{
    /// <inheritdoc />
    public partial class ItemModification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "Itens");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Itens");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "Itens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Itens",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
