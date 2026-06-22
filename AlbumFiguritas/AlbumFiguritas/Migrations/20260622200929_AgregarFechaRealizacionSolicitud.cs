using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlbumFiguritas.Migrations
{
    /// <inheritdoc />
    public partial class AgregarFechaRealizacionSolicitud : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaRealizacion",
                table: "SolicitudesIntercambio",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaRealizacion",
                table: "SolicitudesIntercambio");
        }
    }
}
