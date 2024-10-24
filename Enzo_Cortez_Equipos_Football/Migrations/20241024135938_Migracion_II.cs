using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Enzo_Cortez_Equipos_Football.Migrations
{
    /// <inheritdoc />
    public partial class Migracion_II : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Equipo",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "EstadioId",
                table: "Equipo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEstadio",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IdEstadio",
                table: "Equipo");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Equipo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);
        }
    }
}
