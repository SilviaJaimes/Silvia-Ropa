using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
{
    public void Configure(EntityTypeBuilder<DetalleVenta> builder)
    {

        builder.ToTable("detalleVenta");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .IsRequired();

        builder.HasOne(d => d.Venta)
        .WithMany(d => d.DetalleVentas)
        .HasForeignKey(d => d.IdVenta);

        builder.HasOne(d => d.Producto)
        .WithMany(d => d.DetalleVentas)
        .HasForeignKey(d => d.IdProducto);

        builder.HasOne(d => d.Talla)
        .WithMany(d => d.DetalleVentas)
        .HasForeignKey(d => d.IdTalla);

        builder.Property(p => p.Cantidad)
        .HasColumnName("cantidad")
        .HasColumnType("int")
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.ValorUnit)
        .HasColumnName("valorUnit")
        .HasColumnType("double")
        .HasMaxLength(150)
        .IsRequired();
    }
}