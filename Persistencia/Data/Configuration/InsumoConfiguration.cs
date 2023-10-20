using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
{
    public void Configure(EntityTypeBuilder<Insumo> builder)
    {

        builder.ToTable("insumo");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.Nombre)
        .HasColumnName("nombre")
        .HasColumnType("varchar")
        .HasMaxLength(250)
        .IsRequired();

        builder.Property(p => p.ValorUnit)
        .HasColumnName("valorUnit")
        .HasColumnType("double")
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p => p.StockMin)
        .HasColumnName("stockMin")
        .HasColumnType("int")
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p => p.StockMax)
        .HasColumnName("stockMax")
        .HasColumnType("int")
        .HasMaxLength(100)
        .IsRequired();
    }
}