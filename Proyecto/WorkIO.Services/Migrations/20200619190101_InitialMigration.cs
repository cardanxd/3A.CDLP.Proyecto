using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkIO.Services.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    NomEmpresa = table.Column<string>(nullable: false),
                    NomContacto = table.Column<string>(nullable: false),
                    NumContacto = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.NomEmpresa);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Candidato",
                columns: table => new
                {
                    Nombre = table.Column<string>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Sexo = table.Column<string>(nullable: false),
                    FNacimiento = table.Column<string>(nullable: true),
                    LNacimiento = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    ECivil = table.Column<string>(nullable: true),
                    Nacionalidad = table.Column<string>(nullable: true),
                    NomEmpresa = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidato", x => x.Nombre);
                    table.ForeignKey(
                        name: "FK_Candidato_Empresa_NomEmpresa",
                        column: x => x.NomEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "NomEmpresa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persona_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Visa = table.Column<bool>(nullable: false),
                    Cartilla = table.Column<bool>(nullable: false),
                    Curp = table.Column<string>(nullable: true),
                    Imss = table.Column<string>(nullable: true),
                    Rfc = table.Column<string>(nullable: true),
                    Antecedentes = table.Column<bool>(nullable: false),
                    Pasaporte = table.Column<bool>(nullable: false),
                    Licencia = table.Column<bool>(nullable: false),
                    Ine = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documentos_Candidato_Nombre",
                        column: x => x.Nombre,
                        principalTable: "Candidato",
                        principalColumn: "Nombre",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orden",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(nullable: false),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    NomEmpresa = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orden", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orden_Empresa_NomEmpresa",
                        column: x => x.NomEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "NomEmpresa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orden_Candidato_Nombre",
                        column: x => x.Nombre,
                        principalTable: "Candidato",
                        principalColumn: "Nombre",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Referencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    NomEmpresa = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    NomJefe = table.Column<string>(nullable: false),
                    PuestoJefe = table.Column<string>(nullable: true),
                    NomInformante = table.Column<string>(nullable: false),
                    PuestoInformante = table.Column<string>(nullable: true),
                    PuestoCandidato = table.Column<string>(nullable: true),
                    SueldoMensual = table.Column<int>(nullable: false),
                    InicioLabores = table.Column<string>(nullable: true),
                    FinSeparacion = table.Column<string>(nullable: true),
                    Motivo = table.Column<string>(nullable: false),
                    Contrato = table.Column<string>(nullable: true),
                    Funcion = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Referencia_Candidato_Nombre",
                        column: x => x.Nombre,
                        principalTable: "Candidato",
                        principalColumn: "Nombre",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidato_NomEmpresa",
                table: "Candidato",
                column: "NomEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_Nombre",
                table: "Documentos",
                column: "Nombre");

            migrationBuilder.CreateIndex(
                name: "IX_Orden_NomEmpresa",
                table: "Orden",
                column: "NomEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Orden_Nombre",
                table: "Orden",
                column: "Nombre");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_UsuarioId",
                table: "Persona",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Referencia_Nombre",
                table: "Referencia",
                column: "Nombre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documentos");

            migrationBuilder.DropTable(
                name: "Orden");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Referencia");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Candidato");

            migrationBuilder.DropTable(
                name: "Empresa");
        }
    }
}
