using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginRegistroProjeto.Migrations
{
    public partial class Migration13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventoUsuarios",
                columns: table => new
                {
                    idEvento = table.Column<int>(nullable: false),
                    idUser = table.Column<int>(nullable: false),
                    EventoId = table.Column<int>(nullable: true),
                    UsuarioId = table.Column<string>(nullable: true),
                    EventoAgendaidEvento = table.Column<int>(nullable: true),
                    EventoAgendaidUser = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventoAgendas", x => new { x.idEvento, x.idUser });
                    table.ForeignKey(
                        name: "FK_EventoAgendas_TabEventos_EventoId",
                        column: x => x.EventoId,
                        principalTable: "TabEventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventoAgendas_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventoAgendas_EventoAgendas_EventoAgendaidEvento_EventoAgendaidUser",
                        columns: x => new { x.EventoAgendaidEvento, x.EventoAgendaidUser },
                        principalTable: "EventoUsuarios",
                        principalColumns: new[] { "idEvento", "idUser" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventoAgendas_EventoId",
                table: "EventoUsuarios",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_EventoAgendas_UsuarioId",
                table: "EventoUsuarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_EventoAgendas_EventoAgendaidEvento_EventoAgendaidUser",
                table: "EventoUsuarios",
                columns: new[] { "EventoAgendaidEvento", "EventoAgendaidUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventoUsuarios");
        }
    }
}
