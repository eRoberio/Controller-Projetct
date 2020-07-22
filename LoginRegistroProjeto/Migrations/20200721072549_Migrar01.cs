using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginRegistroProjeto.Migrations
{
    public partial class Migrar01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Log_AspNetUsers_UserRegisterId1",
                table: "Log");

            migrationBuilder.DropIndex(
                name: "IX_Log_UserRegisterId1",
                table: "Log");

            migrationBuilder.DropColumn(
                name: "UserRegisterId1",
                table: "Log");

            migrationBuilder.AlterColumn<string>(
                name: "UserRegisterId",
                table: "Log",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Log_AspNetUsers_UserRegisterId",
                table: "Log");

            migrationBuilder.DropIndex(
                name: "IX_Log_UserRegisterId",
                table: "Log");

            migrationBuilder.AlterColumn<int>(
                name: "UserRegisterId",
                table: "Log",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserRegisterId1",
                table: "Log",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Log_UserRegisterId1",
                table: "Log",
                column: "UserRegisterId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Log_AspNetUsers_UserRegisterId1",
                table: "Log",
                column: "UserRegisterId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
