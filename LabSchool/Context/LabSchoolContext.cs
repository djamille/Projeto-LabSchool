using LabSchool.Models;
using LabSchool.Models.Configurations;
using Microsoft.EntityFrameworkCore;


namespace LabSchool.Context
{
    public class LabSchoolContext : DbContext                       //Classe responsável pela interação com o banco de dados
    {

        public LabSchoolContext(DbContextOptions<LabSchoolContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }                //tabelas no banco de dados, mapeando 
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Pedagogo> Pedagogos { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)                          //Adicionando ("puxando" das classes Configurations) minhas configuraçoes
        {
            modelBuilder.ApplyConfiguration(new AlunoConfiguration());
            modelBuilder.ApplyConfiguration(new ProfessorConfiguration());
            modelBuilder.ApplyConfiguration(new PedagogoConfiguration());
            
        }
    }
}
