using Dominio.Entities;

namespace Dominio.Interfaces;

public interface IPrenda : IGenericRepository<Prenda>
{
    Task<IEnumerable<Object>> InsumosPorPrenda(string CodPrenda);
}