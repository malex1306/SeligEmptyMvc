using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MitarbeiterVerwaltung1.Migrations
{
    /// <inheritdoc />
    public partial class FixMitarbeiter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Produkte",
                table: "Produkte");

            migrationBuilder.RenameTable(
                name: "Produkte",
                newName: "Mitarbeiter");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mitarbeiter",
                table: "Mitarbeiter",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Mitarbeiter",
                table: "Mitarbeiter");

            migrationBuilder.RenameTable(
                name: "Mitarbeiter",
                newName: "Produkte");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produkte",
                table: "Produkte",
                column: "Id");
        }
    }
}
