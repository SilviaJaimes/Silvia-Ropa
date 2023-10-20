using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
{
    public void Configure(EntityTypeBuilder<Empresa> builder)
    {

        builder.ToTable("empresa");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.Nit)
        .HasColumnName("nit")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.RazonSocial)
        .HasColumnName("razonSocial")
        .HasColumnType("varchar")
        .HasMaxLength(250)
        .IsRequired();

        builder.Property(p => p.RepresentanteLegal)
        .HasColumnName("representanteLegal")
        .HasColumnType("varchar")
        .HasMaxLength(250)
        .IsRequired();

        builder.Property(p => p.FechaCreacion)
        .HasColumnName("fechaCreacion")
        .HasColumnType("date")
        .IsRequired();

        builder.HasOne(d => d.Municipio)
        .WithMany(d => d.Empresas)
        .HasForeignKey(d => d.IdMunicipio);
    }
}