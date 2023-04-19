using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace LabSchool.Models.Configurations;

public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
{
    public void Configure(EntityTypeBuilder<Aluno> builder)
    {

        builder.HasKey(x => x.Cod);

        builder.Property(p => p.Nome)
            .IsRequired()
            .HasMaxLength(80);

        builder.Property(p => p.Telefone)
            .IsRequired()
            .HasMaxLength(14);

        builder.Property(p => p.DataNascimento)
            .IsRequired();

        builder.Property(p => p.Situacao)
            .IsRequired();

        builder.Property(p => p.Nota)
            .IsRequired();

        builder.Property(P => P.CPF)
            .HasMaxLength(11)
            .IsRequired();

        builder.HasIndex(P => P.CPF)
            .IsUnique();

        builder.Property(p => p.QtdAtendimento)
            .IsRequired();
      

        builder.ToTable("Aluno");
    }
}