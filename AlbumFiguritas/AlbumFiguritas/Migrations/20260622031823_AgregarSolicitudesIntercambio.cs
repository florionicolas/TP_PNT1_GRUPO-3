using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlbumFiguritas.Migrations
{
    /// <inheritdoc />
    public partial class AgregarSolicitudesIntercambio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SolicitudesIntercambio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    FiguritaOfrecidaId = table.Column<int>(type: "int", nullable: false),
                    FiguritaSolicitadaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudesIntercambio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitudesIntercambio_Figuritas_FiguritaOfrecidaId",
                        column: x => x.FiguritaOfrecidaId,
                        principalTable: "Figuritas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SolicitudesIntercambio_Figuritas_FiguritaSolicitadaId",
                        column: x => x.FiguritaSolicitadaId,
                        principalTable: "Figuritas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SolicitudesIntercambio_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesIntercambio_FiguritaOfrecidaId",
                table: "SolicitudesIntercambio",
                column: "FiguritaOfrecidaId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesIntercambio_FiguritaSolicitadaId",
                table: "SolicitudesIntercambio",
                column: "FiguritaSolicitadaId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesIntercambio_UsuarioId",
                table: "SolicitudesIntercambio",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SolicitudesIntercambio");
        }
    }
}
