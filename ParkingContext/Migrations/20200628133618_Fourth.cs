using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingContext.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carros_Usuarios_UsuarioId",
                table: "Carros");

            migrationBuilder.DropForeignKey(
                name: "FK_Conferencias_Carros_CaroId",
                table: "Conferencias");

            migrationBuilder.DropTable(
                name: "Informacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Conferencias_CaroId",
                table: "Conferencias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carros",
                table: "Carros");

            migrationBuilder.DropIndex(
                name: "IX_Carros_UsuarioId",
                table: "Carros");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "InformacoesJson",
                table: "PastioEstacionamento");

            migrationBuilder.DropColumn(
                name: "Placa",
                table: "PastioEstacionamento");

            migrationBuilder.DropColumn(
                name: "CaroId",
                table: "Conferencias");

            migrationBuilder.DropColumn(
                name: "CaroId",
                table: "Carros");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Carros");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EntradaId",
                table: "PastioEstacionamento",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "Inf",
                table: "Conferencias",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Placa",
                table: "Conferencias",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Placa",
                table: "Carros",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioCpf",
                table: "Carros",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Cpf");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carros",
                table: "Carros",
                column: "Placa");

            migrationBuilder.CreateIndex(
                name: "IX_Conferencias_Placa",
                table: "Conferencias",
                column: "Placa",
                unique: true,
                filter: "[Placa] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Carros_UsuarioCpf",
                table: "Carros",
                column: "UsuarioCpf");

            migrationBuilder.AddForeignKey(
                name: "FK_Carros_Usuarios_UsuarioCpf",
                table: "Carros",
                column: "UsuarioCpf",
                principalTable: "Usuarios",
                principalColumn: "Cpf",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Conferencias_Carros_Placa",
                table: "Conferencias",
                column: "Placa",
                principalTable: "Carros",
                principalColumn: "Placa",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carros_Usuarios_UsuarioCpf",
                table: "Carros");

            migrationBuilder.DropForeignKey(
                name: "FK_Conferencias_Carros_Placa",
                table: "Conferencias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Conferencias_Placa",
                table: "Conferencias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carros",
                table: "Carros");

            migrationBuilder.DropIndex(
                name: "IX_Carros_UsuarioCpf",
                table: "Carros");

            migrationBuilder.DropColumn(
                name: "Placa",
                table: "Conferencias");

            migrationBuilder.DropColumn(
                name: "UsuarioCpf",
                table: "Carros");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "Usuarios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "EntradaId",
                table: "PastioEstacionamento",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "InformacoesJson",
                table: "PastioEstacionamento",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Placa",
                table: "PastioEstacionamento",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Inf",
                table: "Conferencias",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<Guid>(
                name: "CaroId",
                table: "Conferencias",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Placa",
                table: "Carros",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<Guid>(
                name: "CaroId",
                table: "Carros",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "Carros",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carros",
                table: "Carros",
                column: "CaroId");

            migrationBuilder.CreateTable(
                name: "Informacoes",
                columns: table => new
                {
                    DanosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Danos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatioEstacionamentoEntrada = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                name: "IX_Conferencias_CaroId",
                table: "Conferencias",
                column: "CaroId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carros_UsuarioId",
                table: "Carros",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Informacoes_PatioEstacionamentoEntrada",
                table: "Informacoes",
                column: "PatioEstacionamentoEntrada");

            migrationBuilder.AddForeignKey(
                name: "FK_Carros_Usuarios_UsuarioId",
                table: "Carros",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Conferencias_Carros_CaroId",
                table: "Conferencias",
                column: "CaroId",
                principalTable: "Carros",
                principalColumn: "CaroId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
