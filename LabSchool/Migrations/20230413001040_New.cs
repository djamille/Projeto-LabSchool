using LabSchool.Enums;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabSchool.Migrations
{
    /// <inheritdoc />
    public partial class New : Migration
    {
        public string Cod { get; private set; }
        public string QtdAtendimento { get; private set; }
        public string Nota { get; private set; }
        public string CPF { get; private set; }
        public string DataNascimento { get; private set; }
        public string Telefone { get; private set; }
        public string Nome { get; private set; } 
        public EFormacaoAcademica Formacao { get; private set; }
        public EEstado Estado { get; private set; }
        public EExperiencia Experiencia { get; private set; }
        public ESituacaoMatricula Situacao { get; private set; }


        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Aluno",
                columns: new[] { "Cod", "Nome", "Telefone", "DataNascimento", "CPF", "Situacao", "Nota", "QtdAtendimento" },
                values: new object[,]
                {
                    {1, "Bart Simpson", "11-11111-1212",new DateTime(2014,10,29), "11839750073", 2, 3.5, 0},
                    {2, "Lisa Simpson", "11-22222-2222",new DateTime(2012,10,29), "17158947076", 1, 10, 0},
                    {3, "Meggie Simpson", "12-20002-2200",new DateTime(2014,10,29), "63701210020", 1, 9, 0},
                    {4, "Milhouse Van Houten", "11-33333-2222",new DateTime(2019,10,29), "30119137062", 1, 8, 0},
                    {5, "Nelson Muntz", "11-44333-4444",new DateTime(2007,10,29), "95704094015", 3, 2, 0}
                }  
                );

            migrationBuilder.InsertData(
                table: "Pedagogo",
                columns: new[] { "Cod", "Nome", "Telefone", "DataNascimento", "CPF", "QtdAtendimento" },
                values: new object[,]
                {
                    {1, "John Snow", "11-67333-4454",new DateTime(2000,10,30), "62316840086", 0},
                    {2, "Sansa Stark", "22-22333-4454", new DateTime(2004, 10, 30), "49850253053", 0},
                    {3, "Tyrion Lannister", "33-77333-4454", new DateTime(1990, 10, 30), "39125106015", 0},
                    {4, "Sandor Clegane", "11-33333-2222", new DateTime(1995, 10, 30), "89089606009", 0},
                }
                );

            migrationBuilder.InsertData(
                table: "Professor",
                columns: new[] { "Cod", "Nome", "Telefone", "DataNascimento", "CPF", "Estado", "Experiencia", "Formacao" },
                values: new object[,]
                {
                    {1, "Walter White", "14-22998-1882",new DateTime(1982,10,30), "40539019011", 0, 2, 2},
                    {2, "Jesse Pinkman", "44-11111-1992",new DateTime(1997,10,30), "96107295097", 0,  0, 1},
                    {3, "Hank Schrader", "44-11111-1002",new DateTime(1984,10,30), "70685977005", 0,  2, 2},
                    {4, "Gustavo Fring", "44-11001-1002",new DateTime(1977,10,30), "57408927085", 1,  1,  0},
                    {5, "Saul Goodman", "44-11998-1882",new DateTime(1980,10,30), "86940162062", 0,  2, 2}
                }
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
