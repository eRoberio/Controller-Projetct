using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginRegistroProjeto.Migrations
{
    public partial class Migration14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventoUsuarios_EventoUsuarios_EventoAgendaidEvento_EventoAgendaidUser",
                table: "EventoUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_EventoUsuarios_EventoAgendaidEvento_EventoAgendaidUser",
                table: "EventoUsuarios");

            migrationBuilder.DropColumn(
                name: "EventoAgendaidEvento",
                table: "EventoUsuarios");

            migrationBuilder.DropColumn(
                name: "EventoAgendaidUser",
                table: "EventoUsuarios");

            migrationBuilder.AddColumn<int>(
                name: "UserCreateId",
                table: "TabEventos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<Guid>(
                name: "idUser",
                table: "EventoUsuarios",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserCreateId",
                table: "TabEventos");

            migrationBuilder.AlterColumn<int>(
                name: "idUser",
                table: "EventoUsuarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<int>(
                name: "EventoAgendaidEvento",
                table: "EventoUsuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventoAgendaidUser",
                table: "EventoUsuarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventoUsuarios_EventoAgendaidEvento_EventoAgendaidUser",
                table: "EventoUsuarios",
                columns: new[] { "EventoAgendaidEvento", "EventoAgendaidUser" });

            migrationBuilder.AddForeignKey(
                name: "FK_EventoUsuarios_EventoUsuarios_EventoAgendaidEvento_EventoAgendaidUser",
                table: "EventoUsuarios",
                columns: new[] { "EventoAgendaidEvento", "EventoAgendaidUser" },
                principalTable: "EventoUsuarios",
                principalColumns: new[] { "idEvento", "idUser" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
