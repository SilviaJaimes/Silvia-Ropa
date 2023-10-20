using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class InventarioTallaConfiguration : IEntityTypeConfiguration<InventarioTalla>
{
    public void Configure(EntityTypeBuilder<InventarioTalla> builder)
    {

        builder.ToTable("inventarioTalla");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .IsRequired();

        builder.HasOne(d => d.Inventario)
        .WithMany(d => d.InventarioTallas)
        .HasForeignKey(d => d.IdInventario);

        builder.HasOne(d => d.Talla)
        .WithMany(d => d.InventarioTallas)
        .HasForeignKey(d => d.IdTalla);

        builder.Property(p => p.Cantidad)
        .HasColumnName("cantidad")
        .HasColumnType("int")
        .HasMaxLength(100)
        .IsRequired();
    }
}