using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
{
    public void Configure(EntityTypeBuilder<Inventario> builder)
    {

        builder.ToTable("inventario");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.CodInv)
        .HasColumnName("codInv")
        .HasColumnType("varchar")
        .HasMaxLength(100)
        .IsRequired();

        builder.HasOne(d => d.Prenda)
        .WithMany(d => d.Inventarios)
        .HasForeignKey(d => d.IdPrenda);

        builder.Property(p => p.ValorVtaCop)
        .HasColumnName("valorVtaCop")
        .HasColumnType("double")
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.ValorVtaUsd)
        .HasColumnName("valorVtaUsd")
        .HasColumnType("double")
        .HasMaxLength(150)
        .IsRequired();
    }
}