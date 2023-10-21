using Dominio.Entities;

namespace Dominio.Interfaces;

public interface IOrden : IGenericRepository<Orden>
{
    Task<IEnumerable<object>> OrdenesProduccion();
    Task<IEnumerable<Object>> OrdenesPorCliente(int IdCliente);
}