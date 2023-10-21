using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class ProveedorRepository : GenericRepository<Proveedor>, IProveedor
{
    private readonly ApiContext _context;

    public ProveedorRepository(ApiContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Object>> InsumosPorProveedor(string Nit)
    {
        var insumosPorProveedor = await (
            from i in _context.InsumoProveedores
            join p in _context.Proveedores on i.IdProveedor equals p.Id
            join tp in _context.TipoPersonas on p.IdTipoPersona equals tp.Id
            where p.IdProveedor.ToLower() == Nit.ToLower() && tp.Nombre == "Juridico"
            select new
            {
                Insumo = i.IdInsumo,
                Nombre = i.Insumo.Nombre
            }).ToListAsync();

        return insumosPorProveedor;
    }

    public override async Task<IEnumerable<Proveedor>> GetAllAsync()
    {
        return await _context.Proveedores
            .ToListAsync();
    }

    public override async Task<Proveedor> GetByIdAsync(int id)
    {
        return await _context.Proveedores
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }

    public override async Task<(int totalRegistros, IEnumerable<Proveedor> registros)> GetAllAsync(int pageIndez, int pageSize, string search)
    {
        var query = _context.Proveedores as IQueryable<Proveedor>;

        if(!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.Id.ToString().ToLower().Contains(search));
        }

        query = query.OrderBy(p => p.Id);
        var totalRegistros = await query.CountAsync();
        var registros = await query 
            .Skip((pageIndez - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (totalRegistros, registros);
    }
}