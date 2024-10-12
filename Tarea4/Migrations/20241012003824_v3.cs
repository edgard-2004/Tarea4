using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tarea4.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nacionalidad",
                table: "Personajes",
                newName: "Signozodiacal");

            migrationBuilder.AddColumn<string>(
                name: "Raza",
                table: "Personajes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Raza",
                table: "Personajes");

            migrationBuilder.RenameColumn(
                name: "Signozodiacal",
                table: "Personajes",
                newName: "Nacionalidad");
        }
    }
}
