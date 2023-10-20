using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class VentaConfiguration : IEntityTypeConfiguration<Venta>
{
    public void Configure(EntityTypeBuilder<Venta> builder)
    {

        builder.ToTable("venta");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.Fecha)
        .HasColumnName("fecha")
        .HasColumnType("date")
        .IsRequired();

        builder.HasOne(d => d.Empleado)
        .WithMany(d => d.Ventas)
        .HasForeignKey(d => d.IdEmpleado);

        builder.HasOne(d => d.Cliente)
        .WithMany(d => d.Ventas)
        .HasForeignKey(d => d.IdCliente);

        builder.HasOne(d => d.FormaPago)
        .WithMany(d => d.Ventas)
        .HasForeignKey(d => d.IdFormaPago);
    }
}