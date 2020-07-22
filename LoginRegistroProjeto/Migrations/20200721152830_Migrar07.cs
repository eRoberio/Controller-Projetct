using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginRegistroProjeto.Migrations
{
    public partial class Migrar07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TabEventos_AspNetUsers_UserRegisterId",
                table: "TabEventos");

            migrationBuilder.CreateTable(
                name: "InputModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    nome = table.Column<string>(nullable: false),
                    sexo = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: false),
                    ConfirmPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputModel", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TabEventos_InputModel_UserRegisterId",
                table: "TabEventos",
                column: "UserRegisterId",
                principalTable: "InputModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TabEventos_InputModel_UserRegisterId",
                table: "TabEventos");

            migrationBuilder.DropTable(
                name: "InputModel");

            migrationBuilder.AddForeignKey(
                name: "FK_TabEventos_AspNetUsers_UserRegisterId",
                table: "TabEventos",
                column: "UserRegisterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
