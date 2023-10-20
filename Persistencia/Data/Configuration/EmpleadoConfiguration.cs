using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
{
    public void Configure(EntityTypeBuilder<Empleado> builder)
    {

        builder.ToTable("empleado");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.IdEmpleado)
        .HasColumnName("idEmpleado")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Nombre)
        .HasColumnName("nombre")
        .HasColumnType("varchar")
        .HasMaxLength(250)
        .IsRequired();

        builder.HasOne(d => d.Cargo)
        .WithMany(d => d.Empleados)
        .HasForeignKey(d => d.IdCargo);

        builder.Property(p => p.FechaIngreso)
        .HasColumnName("fechaIngreso")
        .HasColumnType("date")
        .IsRequired();

        builder.HasOne(d => d.Municipio)
        .WithMany(d => d.Empleados)
        .HasForeignKey(d => d.IdMunicipio);
    }
}