using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MecanicaWeb.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "fone",
                table: "Cliente",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "dataDeNascimento",
                table: "Cliente",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "cpf",
                table: "Cliente",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "Atendimento",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    data = table.Column<DateTime>(nullable: false),
                    hora = table.Column<DateTime>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    descricao = table.Column<string>(nullable: true),
                    Clienteid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atendimento", x => x.id);
                    table.ForeignKey(
                        name: "FK_Atendimento_Cliente_Clienteid",
                        column: x => x.Clienteid,
                        principalTable: "Cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_Clienteid",
                table: "Atendimento",
                column: "Clienteid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atendimento");

            migrationBuilder.AlterColumn<int>(
                name: "fone",
                table: "Cliente",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "dataDeNascimento",
                table: "Cliente",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "cpf",
                table: "Cliente",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
