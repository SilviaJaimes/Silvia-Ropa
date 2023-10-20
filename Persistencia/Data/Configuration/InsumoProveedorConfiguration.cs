using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistencia.Data.Configuration;

public class InsumoProveedorConfiguration : IEntityTypeConfiguration<InsumoProveedor>
{
    public void Configure(EntityTypeBuilder<InsumoProveedor> builder)
    {

        builder.ToTable("insumoProveedor");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .IsRequired();

        builder.HasOne(d => d.Insumo)
        .WithMany(d => d.InsumoProveedores)
        .HasForeignKey(d => d.IdInsumo);

        builder.HasOne(d => d.Proveedor)
        .WithMany(d => d.InsumoProveedores)
        .HasForeignKey(d => d.IdProveedor);
    }
}