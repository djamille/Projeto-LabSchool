using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LabSchool.Models.Configurations
{
    public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(Key => Key.Cod);
            builder.Property(p => p.Nome).IsRequired().HasMaxLength(80);
            builder.Property(p => p.Telefone).IsRequired(false).HasMaxLength(14);
            builder.Property(p => p.DataNascimento).IsRequired();
            builder.Property(P => P.CPF).HasMaxLength(11);
            builder.HasIndex(P => P.CPF).IsUnique();

            builder.Property(e => e.Nome)
                .HasColumnType("varchar(100)")
                .HasColumnName("nome")
                .HasMaxLength(100)
                .IsRequired();

            builder.HasIndex(e => e.Nome)
                .IsUnique();


            builder.Property(e => e.Telefone)
                .HasColumnType("varchar(13)")
                .HasColumnName("telefone")
                .HasMaxLength(13);


            builder.Property(e => e.DataNascimento).HasDefaultValueSql("getdate()")
                .HasColumnType("DateTime")
                .HasColumnName("data de nascimento")
                .HasMaxLength(13);


            builder.Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .HasColumnName("cpf")
                .HasMaxLength(11)
                .IsRequired();

            builder.HasIndex(e => e.CPF)
                .IsUnique();


            builder.ToTable("Pessoa");
        }
    }
}
