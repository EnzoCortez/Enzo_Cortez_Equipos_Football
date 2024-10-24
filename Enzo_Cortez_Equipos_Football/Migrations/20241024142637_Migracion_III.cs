using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Enzo_Cortez_Equipos_Football.Migrations
{
    /// <inheritdoc />
    public partial class Migracion_III : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipo_Estadio_EstadioId",
                table: "Equipo");

            migrationBuilder.DropIndex(
                name: "IX_Equipo_EstadioId",
                table: "Equipo");

            migrationBuilder.DropColumn(
                name: "EstadioId",
                table: "Equipo");

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_IdEstadio",
                table: "Equipo",
                column: "IdEstadio");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipo_Estadio_IdEstadio",
                table: "Equipo",
                column: "IdEstadio",
                principalTable: "Estadio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipo_Estadio_IdEstadio",
                table: "Equipo");

            migrationBuilder.DropIndex(
                name: "IX_Equipo_IdEstadio",
                table: "Equipo");

            migrationBuilder.AddColumn<int>(
                name: "EstadioId",
                table: "Equipo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_EstadioId",
                table: "Equipo",
                column: "EstadioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipo_Estadio_EstadioId",
                table: "Equipo",
                column: "EstadioId",
                principalTable: "Estadio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
