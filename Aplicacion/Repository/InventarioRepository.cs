using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class InventarioRepository : GenericRepository<Inventario>, IInventario
{
    private readonly ApiContext _context;

    public InventarioRepository(ApiContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Object>> ProductosYTallas()
    {
        var ordenesPorCliente = await (
            from it in _context.InventarioTallas
            join i in _context.Inventarios on it.IdInventario equals i.Id
            join t in _context.Tallas on it.IdTalla equals t.Id
            where i.Id == t.Id
            select new 
            {
                Productos = (from i in _context.Inventarios
                            where i.Id == t.Id
                            select new {
                                IdInventario = i.Id,
                                NombreProducto = i.Prenda.Nombre
                            }).ToList(),

                Tallas = (from t in _context.Tallas
                            where i.Id == t.Id
                            select new {
                                Talla = t.Descripcion,
                                Cantidad = it.Cantidad
                            }).ToList(),
            }).ToListAsync();

        return ordenesPorCliente;
    } 

    public override async Task<IEnumerable<Inventario>> GetAllAsync()
    {
        return await _context.Inventarios
            .ToListAsync();
    }

    public override async Task<Inventario> GetByIdAsync(int id)
    {
        return await _context.Inventarios
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }

    public override async Task<(int totalRegistros, IEnumerable<Inventario> registros)> GetAllAsync(int pageIndez, int pageSize, string search)
    {
        var query = _context.Inventarios as IQueryable<Inventario>;

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