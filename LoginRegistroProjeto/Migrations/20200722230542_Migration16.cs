using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginRegistroProjeto.Migrations
{
    public partial class Migration16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "EventoUsuarioId",
                table: "EventoUsuarios",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "idEvento",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EventoUsuarioId",
                table: "EventoUsuarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<int>(
                name: "idEvento",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid));
        }
    }
}
