using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabSchool.Migrations
{
    /// <inheritdoc />
    public partial class INITIAL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Cod = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Situacao = table.Column<int>(type: "int", nullable: false),
                    Nota = table.Column<float>(type: "real", nullable: false),
                    QtdAtendimento = table.Column<int>(type: "int", maxLength: 80, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Cod);
                });

            migrationBuilder.CreateTable(
                name: "Pedagogo",
                columns: table => new
                {
                    Cod = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QtdAtendimento = table.Column<int>(type: "int", maxLength: 80, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedagogo", x => x.Cod);
                });

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    Cod = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Experiencia = table.Column<int>(type: "int", maxLength: 80, nullable: false),
                    Formacao = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.Cod);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_CPF",
                table: "Aluno",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedagogo_CPF",
                table: "Pedagogo",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Professor_CPF",
                table: "Professor",
                column: "CPF",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.DropTable(
                name: "Pedagogo");

            migrationBuilder.DropTable(
                name: "Professor");
        }
    }
}
