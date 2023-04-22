﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace LabSchool.Models.Configurations;

public class PedagogoConfiguration : IEntityTypeConfiguration<Pedagogo>                         //IEntityTypeConfiguration permite que a configuração seja feita por partes
{
    public void Configure(EntityTypeBuilder<Pedagogo> builder)
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

        builder.Property(P => P.CPF)
            .IsRequired()
            .HasMaxLength(11);

        builder.HasIndex(P => P.CPF)                         //Se existir duplicidade retorna 
            .IsUnique();                                     //Value deve ser único

        builder.Property(p => p.QtdAtendimento)
            .IsRequired(); 
        

        builder.ToTable("Pedagogo");                         //Nome da tabela
    }
}
