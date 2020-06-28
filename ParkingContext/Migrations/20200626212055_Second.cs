using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingContext.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Park");

            migrationBuilder.CreateTable(
                name: "PastioEstacionamento",
                columns: table => new
                {
                    EntradaId = table.Column<Guid>(nullable: false),
                    Placa = table.Column<string>(nullable: true),
                    Vaga = table.Column<int>(nullable: false),
                    Excluido = table.Column<bool>(nullable: false),
                    ValorFinal = table.Column<double>(nullable: false),
                    HoraEntrada = table.Column<DateTime>(nullable: false),
                    HoraSaida = table.Column<DateTime>(nullable: false),
                    Duracao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PastioEstacionamento", x => x.EntradaId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<Guid>(nullable: false),
                    NomeCompleto = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    CaroId = table.Column<Guid>(nullable: false),
                    Placa = table.Column<string>(nullable: true),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Cor = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carros", x => x.CaroId);
                    table.ForeignKey(
                        name: "FK_Carros_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Conferencias",
                columns: table => new
                {
                    Inf = table.Column<Guid>(nullable: false),
                    Informacoes = table.Column<string>(nullable: true),
                    CaroId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conferencias", x => x.Inf);
                    table.ForeignKey(
                        name: "FK_Conferencias_Carros_CaroId",
                        column: x => x.CaroId,
                        principalTable: "Carros",
                        principalColumn: "CaroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carros_UsuarioId",
                table: "Carros",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Conferencias_CaroId",
                table: "Conferencias",
                column: "CaroId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conferencias");

            migrationBuilder.DropTable(
                name: "PastioEstacionamento");

            migrationBuilder.DropTable(
                name: "Carros");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.CreateTable(
                name: "Park",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraSaida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorFinal = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Park", x => x.Id);
                });
        }
    }
}
