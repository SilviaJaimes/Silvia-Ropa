using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
{
    public void Configure(EntityTypeBuilder<DetalleOrden> builder)
    {

        builder.ToTable("detalleOrden");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .IsRequired();

        builder.HasOne(d => d.Orden)
        .WithMany(d => d.DetalleOrdenes)
        .HasForeignKey(d => d.IdOrden);

        builder.HasOne(d => d.Prenda)
        .WithMany(d => d.DetalleOrdenes)
        .HasForeignKey(d => d.IdPrenda);

        builder.Property(p => p.CantidadProducir)
        .HasColumnName("cantidadProducir")
        .HasColumnType("int")
        .HasMaxLength(150)
        .IsRequired();

        builder.HasOne(d => d.Color)
        .WithMany(d => d.DetalleOrdenes)
        .HasForeignKey(d => d.IdColor);

        builder.Property(p => p.CantidadProducida)
        .HasColumnName("cantidadProducida")
        .HasColumnType("int")
        .HasMaxLength(150)
        .IsRequired();

        builder.HasOne(d => d.Estado)
        .WithMany(d => d.DetalleOrdenes)
        .HasForeignKey(d => d.IdEstado);
    }
}