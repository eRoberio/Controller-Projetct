using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginRegistroProjeto.Migrations
{
    public partial class Migrar09 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Log_AspNetUsers_UserRegisterId",
                table: "Log");

            migrationBuilder.DropForeignKey(
                name: "FK_TabEventos_Log_LogId",
                table: "TabEventos");

            migrationBuilder.DropForeignKey(
                name: "FK_TabEventos_InputModel_UserRegisterId",
                table: "TabEventos");

            migrationBuilder.DropTable(
                name: "InputModel");

            migrationBuilder.DropIndex(
                name: "IX_TabEventos_UserRegisterId",
                table: "TabEventos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Log",
                table: "Log");

            migrationBuilder.DropIndex(
                name: "IX_Log_UserRegisterId",
                table: "Log");

            migrationBuilder.DropColumn(
                name: "UserRegisterId",
                table: "TabEventos");

            migrationBuilder.DropColumn(
                name: "UserRegisterId",
                table: "Log");

            migrationBuilder.RenameTable(
                name: "Log",
                newName: "TabLog");

            migrationBuilder.AddColumn<string>(
                name: "DadosUsuarioId",
                table: "TabEventos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DadosUsuarioId",
                table: "TabLog",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TabLog",
                table: "TabLog",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "TabMinhaAgenda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Local = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    LogId = table.Column<int>(nullable: true),
                    DadosUsuarioId = table.Column<string>(nullable: true),
                    DataCadastroEvento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabMinhaAgenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabMinhaAgenda_AspNetUsers_DadosUsuarioId",
                        column: x => x.DadosUsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TabMinhaAgenda_TabLog_LogId",
                        column: x => x.LogId,
                        principalTable: "TabLog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TabEventos_DadosUsuarioId",
                table: "TabEventos",
                column: "DadosUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TabLog_DadosUsuarioId",
                table: "TabLog",
                column: "DadosUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TabMinhaAgenda_DadosUsuarioId",
                table: "TabMinhaAgenda",
                column: "DadosUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TabMinhaAgenda_LogId",
                table: "TabMinhaAgenda",
                column: "LogId");

            migrationBuilder.AddForeignKey(
                name: "FK_TabEventos_AspNetUsers_DadosUsuarioId",
                table: "TabEventos",
                column: "DadosUsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TabEventos_AspNetUsers_DadosUsuarioId",
                table: "TabEventos");

            migrationBuilder.DropForeignKey(
                name: "FK_TabEventos_TabLog_LogId",
                table: "TabEventos");

            migrationBuilder.DropForeignKey(
                name: "FK_TabLog_AspNetUsers_DadosUsuarioId",
                table: "TabLog");

            migrationBuilder.DropTable(
                name: "TabMinhaAgenda");

            migrationBuilder.DropIndex(
                name: "IX_TabEventos_DadosUsuarioId",
                table: "TabEventos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TabLog",
                table: "TabLog");

            migrationBuilder.DropIndex(
                name: "IX_TabLog_DadosUsuarioId",
                table: "TabLog");

            migrationBuilder.DropColumn(
                name: "DadosUsuarioId",
                table: "TabEventos");

            migrationBuilder.DropColumn(
                name: "DadosUsuarioId",
                table: "TabLog");

            migrationBuilder.RenameTable(
                name: "TabLog",
                newName: "Log");

            migrationBuilder.AddColumn<int>(
                name: "UserRegisterId",
                table: "TabEventos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserRegisterId",
                table: "Log",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Log",
                table: "Log",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "InputModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sexo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputModel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TabEventos_UserRegisterId",
                table: "TabEventos",
                column: "UserRegisterId");

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
                name: "FK_TabEventos_Log_LogId",
                table: "TabEventos",
                column: "LogId",
                principalTable: "Log",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TabEventos_InputModel_UserRegisterId",
                table: "TabEventos",
                column: "UserRegisterId",
                principalTable: "InputModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
