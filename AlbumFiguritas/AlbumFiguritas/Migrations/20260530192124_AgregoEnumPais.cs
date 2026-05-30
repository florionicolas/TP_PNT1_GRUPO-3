using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlbumFiguritas.Migrations
{
    /// <inheritdoc />
    public partial class AgregoEnumPais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Seleccion",
                table: "Figuritas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Figuritas",
                columns: new[] { "Id", "NombreJugador", "Numero", "Seleccion", "UrlFotoJugador" },
                values: new object[,]
                {
                    { 1, "Emiliano Martinez", 1, 3, null },
                    { 2, "Nahuel Molina", 2, 3, null },
                    { 3, "Cristian Romero", 3, 3, null },
                    { 4, "Nicolas Otamendi", 4, 3, null },
                    { 5, "Nicolas Tagliafico", 5, 3, null },
                    { 6, "Rodrigo De Paul", 6, 3, null },
                    { 7, "Enzo Fernandez", 7, 3, null },
                    { 8, "Alexis Mac Allister", 8, 3, null },
                    { 9, "Julian Alvarez", 9, 3, null },
                    { 10, "Lionel Messi", 10, 3, null },
                    { 11, "Alisson Becker", 11, 8, null },
                    { 12, "Danilo", 12, 8, null },
                    { 13, "Marquinhos", 13, 8, null },
                    { 14, "Thiago Silva", 14, 8, null },
                    { 15, "Casemiro", 15, 8, null },
                    { 16, "Lucas Paqueta", 16, 8, null },
                    { 17, "Neymar Jr", 17, 8, null },
                    { 18, "Vinicius Jr", 18, 8, null },
                    { 19, "Richarlison", 19, 8, null },
                    { 20, "Raphinha", 20, 8, null },
                    { 21, "Hugo Lloris", 21, 22, null },
                    { 22, "Raphael Varane", 22, 22, null },
                    { 23, "Dayot Upamecano", 23, 22, null },
                    { 24, "Theo Hernandez", 24, 22, null },
                    { 25, "Aurelien Tchouameni", 25, 22, null },
                    { 26, "Adrien Rabiot", 26, 22, null },
                    { 27, "Antoine Griezmann", 27, 22, null },
                    { 28, "Ousmane Dembele", 28, 22, null },
                    { 29, "Kylian Mbappe", 29, 22, null },
                    { 30, "Olivier Giroud", 30, 22, null },
                    { 31, "Jordan Pickford", 31, 25, null },
                    { 32, "Kyle Walker", 32, 25, null },
                    { 33, "John Stones", 33, 25, null },
                    { 34, "Harry Maguire", 34, 25, null },
                    { 35, "Luke Shaw", 35, 25, null },
                    { 36, "Declan Rice", 36, 25, null },
                    { 37, "Jude Bellingham", 37, 25, null },
                    { 38, "Bukayo Saka", 38, 25, null },
                    { 39, "Phil Foden", 39, 25, null },
                    { 40, "Harry Kane", 40, 25, null }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "NombreUsuario", "Password", "Permiso" },
                values: new object[,]
                {
                    { 1, "admingabi@test.com", "adminGabi", "123", 0 },
                    { 2, "admineze@test.com", "adminEze", "123", 0 },
                    { 3, "adminnico@test.com", "adminNico", "123", 0 },
                    { 4, "gabi@test.com", "defaultGabi", "123", 1 },
                    { 5, "eze@test.com", "defaultEze", "123", 1 },
                    { 6, "nico@test.com", "defaultNico", "123", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Figuritas",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Seleccion",
                table: "Figuritas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
