using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkIO.Services.Migrations
{
    public partial class Ordenes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Ordens",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FechaLimite",
                table: "Ordens",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Ordens",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TipoContrato",
                table: "Ordens",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Ordens");

            migrationBuilder.DropColumn(
                name: "FechaLimite",
                table: "Ordens");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Ordens");

            migrationBuilder.DropColumn(
                name: "TipoContrato",
                table: "Ordens");
        }
    }
}
