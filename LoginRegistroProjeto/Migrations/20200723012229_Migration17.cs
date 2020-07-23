using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginRegistroProjeto.Migrations
{
    public partial class Migration17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TabEventos_EventosId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_EventoUsuarios_TabEventos_EventoId",
                table: "EventoUsuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventoUsuarios",
                table: "EventoUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EventosId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "idEvento",
                table: "EventoUsuarios");

            migrationBuilder.DropColumn(
                name: "idUser",
                table: "EventoUsuarios");

            migrationBuilder.DropColumn(
                name: "EventosId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "UserCreateId",
                table: "TabEventos",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "EventoUsuarioId",
                table: "EventoUsuarios",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "EventoId",
                table: "EventoUsuarios",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "EventoUsuarios",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventoUsuarios",
                table: "EventoUsuarios",
                column: "EventoUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TabEventos_UserCreateId",
                table: "TabEventos",
                column: "UserCreateId",
                unique: true,
                filter: "[UserCreateId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_EventoUsuarios_TabEventos_EventoId",
                table: "EventoUsuarios",
                column: "EventoId",
                principalTable: "TabEventos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TabEventos_AspNetUsers_UserCreateId",
                table: "TabEventos",
                column: "UserCreateId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventoUsuarios_TabEventos_EventoId",
                table: "EventoUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TabEventos_AspNetUsers_UserCreateId",
                table: "TabEventos");

            migrationBuilder.DropIndex(
                name: "IX_TabEventos_UserCreateId",
                table: "TabEventos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventoUsuarios",
                table: "EventoUsuarios");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "EventoUsuarios");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserCreateId",
                table: "TabEventos",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EventoId",
                table: "EventoUsuarios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<Guid>(
                name: "EventoUsuarioId",
                table: "EventoUsuarios",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "idEvento",
                table: "EventoUsuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "idUser",
                table: "EventoUsuarios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "EventosId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventoUsuarios",
                table: "EventoUsuarios",
                columns: new[] { "idEvento", "idUser" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_EventoUsuarios_TabEventos_EventoId",
                table: "EventoUsuarios",
                column: "EventoId",
                principalTable: "TabEventos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
