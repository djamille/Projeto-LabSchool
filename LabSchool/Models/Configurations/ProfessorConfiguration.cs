using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LabSchool.Models.Configurations;

public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
{
    public void Configure(EntityTypeBuilder<Professor> builder)
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

        builder.Property(P => P.CPF)
            .HasMaxLength(11);

        builder.HasIndex(P => P.CPF)
            .IsUnique();

        builder.Property(p => p.Formacao)
            .IsRequired();

        builder.Property(p => p.Estado)
            .IsRequired();

        builder.Property(p => p.Experiencia)
            .IsRequired();
        
        builder.ToTable("Professor");
    }
}
