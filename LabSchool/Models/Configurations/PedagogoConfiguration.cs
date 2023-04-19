using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace LabSchool.Models.Configurations;

public class PedagogoConfiguration : IEntityTypeConfiguration<Pedagogo>
{
    public void Configure(EntityTypeBuilder<Pedagogo> builder)
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
            .IsRequired()
            .HasMaxLength(11);

        builder.HasIndex(P => P.CPF)
            .IsUnique();

        builder.Property(p => p.QtdAtendimento)
            .IsRequired(); 
        

        builder.ToTable("Pedagogo");
    }
}
