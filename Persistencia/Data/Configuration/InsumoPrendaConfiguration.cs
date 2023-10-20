using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
{
    public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
    {

        builder.ToTable("insumoPrenda");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .IsRequired();

        builder.HasOne(d => d.Insumo)
        .WithMany(d => d.InsumoPrendas)
        .HasForeignKey(d => d.IdInsumo);

        builder.HasOne(d => d.Prenda)
        .WithMany(d => d.InsumoPrendas)
        .HasForeignKey(d => d.IdPrenda);

        builder.Property(p => p.Cantidad)
        .HasColumnName("cantidad")
        .HasColumnType("int")
        .HasMaxLength(100)
        .IsRequired();
    }
}