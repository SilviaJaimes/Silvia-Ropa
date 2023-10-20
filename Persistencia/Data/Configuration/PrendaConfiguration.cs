using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>
{
    public void Configure(EntityTypeBuilder<Prenda> builder)
    {

        builder.ToTable("prenda");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.IdPrenda)
        .HasColumnName("idPrenda")
        .HasColumnType("varchar")
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p => p.Nombre)
        .HasColumnName("nombre")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.ValorUnitCop)
        .HasColumnName("valorUnitCop")
        .HasColumnType("double")
        .HasMaxLength(200)
        .IsRequired();

        builder.Property(p => p.ValorUnitUsd)
        .HasColumnName("valorUnitUsd")
        .HasColumnType("double")
        .HasMaxLength(200)
        .IsRequired();

        builder.HasOne(d => d.Estado)
        .WithMany(d => d.Prendas)
        .HasForeignKey(d => d.IdEstado);

        builder.HasOne(d => d.TipoProteccion)
        .WithMany(d => d.Prendas)
        .HasForeignKey(d => d.IdTipoProteccion);

        builder.HasOne(d => d.Genero)
        .WithMany(d => d.Prendas)
        .HasForeignKey(d => d.IdGenero);
    }
}