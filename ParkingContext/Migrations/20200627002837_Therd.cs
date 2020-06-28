using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingContext.Migrations
{
    public partial class Therd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeCompleto",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Usuarios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InformacoesJson",
                table: "PastioEstacionamento",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Mensalista",
                table: "PastioEstacionamento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Informacoes",
                columns: table => new
                {
                    DanosId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Danos = table.Column<string>(nullable: true),
                    PatioEstacionamentoEntrada = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informacoes", x => x.DanosId);
                    table.ForeignKey(
                        name: "FK_Informacoes_PastioEstacionamento_PatioEstacionamentoEntrada",
                        column: x => x.PatioEstacionamentoEntrada,
                        principalTable: "PastioEstacionamento",
                        principalColumn: "EntradaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Informacoes_PatioEstacionamentoEntrada",
                table: "Informacoes",
                column: "PatioEstacionamentoEntrada");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Informacoes");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "InformacoesJson",
                table: "PastioEstacionamento");

            migrationBuilder.DropColumn(
                name: "Mensalista",
                table: "PastioEstacionamento");

            migrationBuilder.AlterColumn<string>(
                name: "NomeCompleto",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
