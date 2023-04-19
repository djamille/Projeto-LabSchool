using LabSchool.Models;
using LabSchool.Models.Configurations;
using Microsoft.EntityFrameworkCore;


namespace LabSchool.Context
{
    public class LabSchoolContext : DbContext
    {

        public LabSchoolContext(DbContextOptions<LabSchoolContext> options) : base(options)
        {

        }


        public DbSet<Aluno> Alunos { get; set; }                //tabelas no banco de dados
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Pedagogo> Pedagogos { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoConfiguration());
            modelBuilder.ApplyConfiguration(new ProfessorConfiguration());
            modelBuilder.ApplyConfiguration(new PedagogoConfiguration());
            
        }
    }
}
