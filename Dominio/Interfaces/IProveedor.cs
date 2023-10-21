using Dominio.Entities;

namespace Dominio.Interfaces;

public interface IProveedor : IGenericRepository<Proveedor>
{
    Task<IEnumerable<Object>> InsumosPorProveedor(string Nit);
}