using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginRegistroProjeto.Migrations
{
    public partial class Migration15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ID_EVENTO",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserCreateId",
                table: "TabEventos",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "EventoUsuarioId",
                table: "EventoUsuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idEvento",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventoUsuarioId",
                table: "EventoUsuarios");

            migrationBuilder.DropColumn(
                name: "idEvento",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreateId",
                table: "TabEventos",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<int>(
                name: "ID_EVENTO",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
