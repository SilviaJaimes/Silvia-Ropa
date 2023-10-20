using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
{
    public void Configure(EntityTypeBuilder<Proveedor> builder)
    {

        builder.ToTable("proveedor");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.IdProveedor)
        .HasColumnName("idProveedor")
        .HasColumnType("varchar")
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p => p.Nombre)
        .HasColumnName("nombre")
        .HasColumnType("varchar")
        .HasMaxLength(250)
        .IsRequired();

        builder.HasOne(d => d.TipoPersona)
        .WithMany(d => d.Proveedores)
        .HasForeignKey(d => d.IdTipoPersona);

        builder.HasOne(d => d.Municipio)
        .WithMany(d => d.Proveedores)
        .HasForeignKey(d => d.IdMunicipio);
    }
}