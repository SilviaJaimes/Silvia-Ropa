using Dominio.Entities;

namespace Dominio.Interfaces;

public interface IVenta : IGenericRepository<Venta>
{
    Task<IEnumerable<Object>> VentaPorEmpleado(int IdEmpleado);
}