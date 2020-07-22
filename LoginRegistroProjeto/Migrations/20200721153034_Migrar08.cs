using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginRegistroProjeto.Migrations
{
    public partial class Migrar08 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserRegisterId",
                table: "TabEventos",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "InputModel",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserRegisterId",
                table: "TabEventos",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "InputModel",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
