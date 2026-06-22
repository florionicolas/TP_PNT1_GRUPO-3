using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlbumFiguritas.Migrations
{
    /// <inheritdoc />
    public partial class ResolucionTypo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 26,
                column: "NombreJugador",
                value: "Kingsley Coman");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 26,
                column: "NombreJugador",
                value: "Kingsley Koman");
        }
    }
}
