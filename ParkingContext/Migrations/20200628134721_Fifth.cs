using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingContext.Migrations
{
    public partial class Fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EntradaId",
                table: "PastioEstacionamento",
                newName: "PlacaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlacaId",
                table: "PastioEstacionamento",
                newName: "EntradaId");
        }
    }
}
