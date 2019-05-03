using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MecanicaWeb.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Profissionalid",
                table: "Atendimento",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    data = table.Column<DateTime>(nullable: false),
                    hora = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Profissional",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(nullable: true),
                    fone = table.Column<double>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    Agendaid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profissional", x => x.id);
                    table.ForeignKey(
                        name: "FK_Profissional_Agenda_Agendaid",
                        column: x => x.Agendaid,
                        principalTable: "Agenda",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_Profissionalid",
                table: "Atendimento",
                column: "Profissionalid");

            migrationBuilder.CreateIndex(
                name: "IX_Profissional_Agendaid",
                table: "Profissional",
                column: "Agendaid");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Profissional_Profissionalid",
                table: "Atendimento",
                column: "Profissionalid",
                principalTable: "Profissional",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Profissional_Profissionalid",
                table: "Atendimento");

            migrationBuilder.DropTable(
                name: "Profissional");

            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropIndex(
                name: "IX_Atendimento_Profissionalid",
                table: "Atendimento");

            migrationBuilder.DropColumn(
                name: "Profissionalid",
                table: "Atendimento");
        }
    }
}
