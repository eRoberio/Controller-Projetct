using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginRegistroProjeto.Migrations
{
    public partial class Migrar10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TabEventos_AspNetUsers_DadosUsuarioId",
                table: "TabEventos");

            migrationBuilder.DropIndex(
                name: "IX_TabEventos_DadosUsuarioId",
                table: "TabEventos");

            migrationBuilder.DropColumn(
                name: "DadosUsuarioId",
                table: "TabEventos");

            migrationBuilder.AddColumn<int>(
                name: "EventosId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ID_EVENTO",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EventosId",
                table: "AspNetUsers",
                column: "EventosId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TabEventos_EventosId",
                table: "AspNetUsers",
                column: "EventosId",
                principalTable: "TabEventos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TabEventos_EventosId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EventosId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EventosId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ID_EVENTO",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "DadosUsuarioId",
                table: "TabEventos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TabEventos_DadosUsuarioId",
                table: "TabEventos",
                column: "DadosUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_TabEventos_AspNetUsers_DadosUsuarioId",
                table: "TabEventos",
                column: "DadosUsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
