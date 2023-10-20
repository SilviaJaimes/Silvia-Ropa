using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {

        builder.ToTable("cliente");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.IdCliente)
        .HasColumnName("idCliente")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Nombre)
        .HasColumnName("nombre")
        .HasColumnType("varchar")
        .HasMaxLength(250)
        .IsRequired();

        builder.HasOne(d => d.TipoPersona)
        .WithMany(d => d.Clientes)
        .HasForeignKey(d => d.IdTipoPersona);

        builder.Property(p => p.FechaRegistro)
        .HasColumnName("fechaRegistro")
        .HasColumnType("date")
        .IsRequired();

        builder.HasOne(d => d.Municipio)
        .WithMany(d => d.Clientes)
        .HasForeignKey(d => d.IdMunicipio);
    }
}