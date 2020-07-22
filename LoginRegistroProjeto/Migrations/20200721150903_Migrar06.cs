using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginRegistroProjeto.Migrations
{
    public partial class Migrar06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LogId",
                table: "TabEventos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TabEventos_LogId",
                table: "TabEventos",
                column: "LogId");

            migrationBuilder.AddForeignKey(
                name: "FK_TabEventos_Log_LogId",
                table: "TabEventos",
                column: "LogId",
                principalTable: "Log",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TabEventos_Log_LogId",
                table: "TabEventos");

            migrationBuilder.DropIndex(
                name: "IX_TabEventos_LogId",
                table: "TabEventos");

            migrationBuilder.DropColumn(
                name: "LogId",
                table: "TabEventos");
        }
    }
}
