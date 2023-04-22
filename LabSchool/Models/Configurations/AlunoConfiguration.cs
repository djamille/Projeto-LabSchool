using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace LabSchool.Models.Configurations;

public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>                         //IEntityTypeConfiguration permite que a configuração seja feita por partes
{
    public void Configure(EntityTypeBuilder<Aluno> builder)                         //Configura a entidade
    {

        builder.HasKey(x => x.Cod);                         //Define chave primária

        builder.Property(p => p.Nome)                       //Define propriedade de uma entidade
            .IsRequired()                                   //"Obrigatório"
            .HasMaxLength(80);                              //Maximo de caraceteres aceitos

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

        builder.HasIndex(P => P.CPF)                         //Se existir duplicidade retorna
            .IsUnique();                                     //Value deve ser único

        builder.Property(p => p.QtdAtendimento)
            .IsRequired();
      

        builder.ToTable("Aluno");                         //Nome da tabela
    }
}