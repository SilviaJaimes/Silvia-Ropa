using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {

        builder.ToTable("Departamento");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.Nombre)
        .HasColumnName("descripcion")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder.HasOne(d => d.Pais)
        .WithMany(d => d.Departamentos)
        .HasForeignKey(d => d.IdPais);
    }
}