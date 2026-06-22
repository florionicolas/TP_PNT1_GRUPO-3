using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlbumFiguritas.Migrations
{
    /// <inheritdoc />
    public partial class AgregarUrlFotoJugador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UrlFotoJugador",
                table: "Figuritas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UrlFotoJugador",
                value: "img/Emiliano Martinez.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UrlFotoJugador",
                value: "img/Nahuel Molina.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UrlFotoJugador",
                value: "img/Cristian Romero.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UrlFotoJugador",
                value: "img/Nicolas Otamendi.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UrlFotoJugador",
                value: "img/Nicolas Tagliafico.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 6,
                column: "UrlFotoJugador",
                value: "img/Rodrigo De Paul.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 7,
                column: "UrlFotoJugador",
                value: "img/Enzo Fernandez.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 8,
                column: "UrlFotoJugador",
                value: "img/Alexis Mac Allister.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 9,
                column: "UrlFotoJugador",
                value: "img/Julian Alvarez.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 10,
                column: "UrlFotoJugador",
                value: "img/Lionel Messi.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 11,
                column: "UrlFotoJugador",
                value: "img/Alisson Becker.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 12,
                column: "UrlFotoJugador",
                value: "img/Bruno Guimaraes.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 13,
                column: "UrlFotoJugador",
                value: "img/Casemiro.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 14,
                column: "UrlFotoJugador",
                value: "img/Danilo.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 15,
                column: "UrlFotoJugador",
                value: "img/Lucas Paqueta.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 16,
                column: "UrlFotoJugador",
                value: "img/Marquinhos.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 17,
                column: "UrlFotoJugador",
                value: "img/Mateus Cunha.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 18,
                column: "UrlFotoJugador",
                value: "img/Raphinha.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 19,
                column: "UrlFotoJugador",
                value: "img/Vinicius Junior.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 20,
                column: "UrlFotoJugador",
                value: "img/Wesley.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 21,
                column: "UrlFotoJugador",
                value: "img/Aurelien Tchouameni.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 22,
                column: "UrlFotoJugador",
                value: "img/Dayot Upamecano.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 23,
                column: "UrlFotoJugador",
                value: "img/Desire Doue.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 24,
                column: "UrlFotoJugador",
                value: "img/Eduardo Camavinga.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 25,
                column: "UrlFotoJugador",
                value: "img/Ibrahima Konate.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 26,
                column: "UrlFotoJugador",
                value: "img/Kingsley Koman.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 27,
                column: "UrlFotoJugador",
                value: "img/Kylian Mbappe.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 28,
                column: "UrlFotoJugador",
                value: "img/Mike Maignan.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 29,
                column: "UrlFotoJugador",
                value: "img/Ousmane Dembele.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 30,
                column: "UrlFotoJugador",
                value: "img/Theo Hernandez.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 31,
                column: "UrlFotoJugador",
                value: "img/Alexander Arnold.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 32,
                column: "UrlFotoJugador",
                value: "img/Declan Rice.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 33,
                column: "UrlFotoJugador",
                value: "img/Ezri Konsa.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 34,
                column: "UrlFotoJugador",
                value: "img/Harry Kane.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 35,
                column: "UrlFotoJugador",
                value: "img/John Stones.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 36,
                column: "UrlFotoJugador",
                value: "img/Jordan Henderson.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 37,
                column: "UrlFotoJugador",
                value: "img/Jordan Pickford.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 38,
                column: "UrlFotoJugador",
                value: "img/Jude Bellingham.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 39,
                column: "UrlFotoJugador",
                value: "img/Phil Foden.jpg");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 40,
                column: "UrlFotoJugador",
                value: "img/Reece James.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UrlFotoJugador",
                table: "Figuritas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 6,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 7,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 8,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 9,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 10,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 11,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 12,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 13,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 14,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 15,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 16,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 17,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 18,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 19,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 20,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 21,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 22,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 23,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 24,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 25,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 26,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 27,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 28,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 29,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 30,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 31,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 32,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 33,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 34,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 35,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 36,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 37,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 38,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 39,
                column: "UrlFotoJugador",
                value: null);

            migrationBuilder.UpdateData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 40,
                column: "UrlFotoJugador",
                value: null);
        }
    }
}
