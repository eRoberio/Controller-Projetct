using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginRegistroProjeto.Migrations
{
    public partial class Migration12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TabMinhaAgenda_AspNetUsers_DadosUsuarioId",
                table: "TabMinhaAgenda");

            migrationBuilder.DropForeignKey(
                name: "FK_TabMinhaAgenda_TabLog_LogId",
                table: "TabMinhaAgenda");

            migrationBuilder.DropIndex(
                name: "IX_TabMinhaAgenda_DadosUsuarioId",
                table: "TabMinhaAgenda");

            migrationBuilder.DropIndex(
                name: "IX_TabMinhaAgenda_LogId",
                table: "TabMinhaAgenda");

            migrationBuilder.DropColumn(
                name: "DadosUsuarioId",
                table: "TabMinhaAgenda");

            migrationBuilder.DropColumn(
                name: "LogId",
                table: "TabMinhaAgenda");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DadosUsuarioId",
                table: "TabMinhaAgenda",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LogId",
                table: "TabMinhaAgenda",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TabMinhaAgenda_DadosUsuarioId",
                table: "TabMinhaAgenda",
                column: "DadosUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TabMinhaAgenda_LogId",
                table: "TabMinhaAgenda",
                column: "LogId");

            migrationBuilder.AddForeignKey(
                name: "FK_TabMinhaAgenda_AspNetUsers_DadosUsuarioId",
                table: "TabMinhaAgenda",
                column: "DadosUsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TabMinhaAgenda_TabLog_LogId",
                table: "TabMinhaAgenda",
                column: "LogId",
                principalTable: "TabLog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
