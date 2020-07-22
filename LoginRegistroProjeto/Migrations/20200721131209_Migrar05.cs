using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginRegistroProjeto.Migrations
{
    public partial class Migrar05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TabEventos_Log_LogsId",
                table: "TabEventos");

            migrationBuilder.DropIndex(
                name: "IX_TabEventos_LogsId",
                table: "TabEventos");

            migrationBuilder.DropColumn(
                name: "LogsId",
                table: "TabEventos");

            migrationBuilder.AddColumn<string>(
                name: "UserRegisterId",
                table: "TabEventos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TabEventos_UserRegisterId",
                table: "TabEventos",
                column: "UserRegisterId");

            migrationBuilder.AddForeignKey(
                name: "FK_TabEventos_AspNetUsers_UserRegisterId",
                table: "TabEventos",
                column: "UserRegisterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TabEventos_AspNetUsers_UserRegisterId",
                table: "TabEventos");

            migrationBuilder.DropIndex(
                name: "IX_TabEventos_UserRegisterId",
                table: "TabEventos");

            migrationBuilder.DropColumn(
                name: "UserRegisterId",
                table: "TabEventos");

            migrationBuilder.AddColumn<int>(
                name: "LogsId",
                table: "TabEventos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TabEventos_LogsId",
                table: "TabEventos",
                column: "LogsId");

            migrationBuilder.AddForeignKey(
                name: "FK_TabEventos_Log_LogsId",
                table: "TabEventos",
                column: "LogsId",
                principalTable: "Log",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
