using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginRegistroProjeto.Migrations
{
    public partial class Migration11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TabEventos_TabLog_LogId",
                table: "TabEventos");

            migrationBuilder.DropForeignKey(
                name: "FK_TabLog_AspNetUsers_DadosUsuarioId",
                table: "TabLog");

            migrationBuilder.DropIndex(
                name: "IX_TabLog_DadosUsuarioId",
                table: "TabLog");

            migrationBuilder.DropIndex(
                name: "IX_TabEventos_LogId",
                table: "TabEventos");

            migrationBuilder.DropColumn(
                name: "DadosUsuarioId",
                table: "TabLog");

            migrationBuilder.DropColumn(
                name: "LogId",
                table: "TabEventos");

            migrationBuilder.DropColumn(
                name: "dataCadastroEvento",
                table: "TabEventos");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataEvento",
                table: "TabEventos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LogId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LogId",
                table: "AspNetUsers",
                column: "LogId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TabLog_LogId",
                table: "AspNetUsers",
                column: "LogId",
                principalTable: "TabLog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TabLog_LogId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_LogId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DataEvento",
                table: "TabEventos");

            migrationBuilder.DropColumn(
                name: "LogId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "DadosUsuarioId",
                table: "TabLog",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LogId",
                table: "TabEventos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "dataCadastroEvento",
                table: "TabEventos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_TabLog_DadosUsuarioId",
                table: "TabLog",
                column: "DadosUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TabEventos_LogId",
                table: "TabEventos",
                column: "LogId");

            migrationBuilder.AddForeignKey(
                name: "FK_TabEventos_TabLog_LogId",
                table: "TabEventos",
                column: "LogId",
                principalTable: "TabLog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TabLog_AspNetUsers_DadosUsuarioId",
                table: "TabLog",
                column: "DadosUsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
