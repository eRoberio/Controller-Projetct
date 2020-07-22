using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginRegistroProjeto.Migrations
{
    public partial class Migrar02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "LogsId",
                table: "TabEventos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserRegisterId",
                table: "Log",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TabEventos_LogsId",
                table: "TabEventos",
                column: "LogsId");

            migrationBuilder.CreateIndex(
                name: "IX_Log_UserRegisterId",
                table: "Log",
                column: "UserRegisterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Log_AspNetUsers_UserRegisterId",
                table: "Log",
                column: "UserRegisterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TabEventos_Log_LogsId",
                table: "TabEventos",
                column: "LogsId",
                principalTable: "Log",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Log_AspNetUsers_UserRegisterId",
                table: "Log");

            migrationBuilder.DropForeignKey(
                name: "FK_TabEventos_Log_LogsId",
                table: "TabEventos");

            migrationBuilder.DropIndex(
                name: "IX_TabEventos_LogsId",
                table: "TabEventos");

            migrationBuilder.DropIndex(
                name: "IX_Log_UserRegisterId",
                table: "Log");

            migrationBuilder.DropColumn(
                name: "LogsId",
                table: "TabEventos");

            migrationBuilder.DropColumn(
                name: "UserRegisterId",
                table: "Log");

            migrationBuilder.AddColumn<int>(
                name: "LogId",
                table: "TabEventos",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
