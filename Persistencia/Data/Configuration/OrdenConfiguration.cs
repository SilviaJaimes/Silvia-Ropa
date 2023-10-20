using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
{
    public void Configure(EntityTypeBuilder<Orden> builder)
    {

        builder.ToTable("orden");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.Fecha)
        .HasColumnName("fecha")
        .HasColumnType("date")
        .IsRequired();

        builder.HasOne(d => d.Empleado)
        .WithMany(d => d.Ordenes)
        .HasForeignKey(d => d.IdEmpleado);

        builder.HasOne(d => d.Cliente)
        .WithMany(d => d.Ordenes)
        .HasForeignKey(d => d.IdCliente);

        builder.HasOne(d => d.Estado)
        .WithMany(d => d.Ordenes)
        .HasForeignKey(d => d.IdEstado);
    }
}