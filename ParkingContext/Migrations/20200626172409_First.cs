using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingContext.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Park",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(nullable: true),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Cor = table.Column<string>(nullable: true),
                    HoraEntrada = table.Column<DateTime>(nullable: false),
                    HoraSaida = table.Column<DateTime>(nullable: false),
                    Duracao = table.Column<DateTime>(nullable: false),
                    ValorFinal = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Park", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Park");
        }
    }
}
