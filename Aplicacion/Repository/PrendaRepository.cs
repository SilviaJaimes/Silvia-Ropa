using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class PrendaRepository : GenericRepository<Prenda>, IPrenda
{
    private readonly ApiContext _context;

    public PrendaRepository(ApiContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Object>> InsumosPorPrenda(string CodPrenda)
    {
        var insumosPorPrenda = await (
            from i in _context.InsumoPrendas
            join p in _context.Prendas on i.IdPrenda equals p.Id
            where p.IdPrenda.ToLower() == CodPrenda.ToLower()
            group i by p.Id into prendas
            select new
            {
                Prenda = prendas.Key,
                Insumos = prendas.Select(insumo => new 
                {
                    Id = insumo.Id,
                    Nombre = insumo.Insumo.Nombre,
                    StockMax = insumo.Insumo.StockMax,
                    StockMin = insumo.Insumo.StockMin
                }).ToList()
            }).ToListAsync();

        return insumosPorPrenda;
    }

    public override async Task<IEnumerable<Prenda>> GetAllAsync()
    {
        return await _context.Prendas
            .ToListAsync();
    }

    public override async Task<Prenda> GetByIdAsync(int id)
    {
        return await _context.Prendas
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }

    public override async Task<(int totalRegistros, IEnumerable<Prenda> registros)> GetAllAsync(int pageIndez, int pageSize, string search)
    {
        var query = _context.Prendas as IQueryable<Prenda>;

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