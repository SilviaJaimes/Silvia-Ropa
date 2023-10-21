using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class OrdenRepository : GenericRepository<Orden>, IOrden
{
    private readonly ApiContext _context;

    public OrdenRepository(ApiContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<object>> OrdenesProduccion()
    {
        var procesadas = await (
            from o in _context.Ordenes
            join e in _context.Estados on o.IdEstado equals e.Id

            where e.Descripcion == "En proceso"

            select new{
                IdOrden = o.Id,
                FechaOrden = o.Fecha
            }).Distinct()
            .ToListAsync();
        return procesadas;
    } 

    public async Task<IEnumerable<Object>> OrdenesPorCliente(int IdCliente)
    {
        var ordenesPorCliente = await (
            from d in _context.DetalleOrdenes
            join o in _context.Ordenes on d.IdOrden equals o.Id
            join c in _context.Clientes on o.IdCliente equals c.Id
            join e in _context.Estados on o.IdEstado equals e.Id
            where c.Id == IdCliente 
            select new 
            {
                Cliente = (from c in _context.Clientes
                            where c.Id == IdCliente
                            select new {
                                IdCliente = c.Id,
                                Nombre = c.Nombre,
                                Municipio = c.Municipio.Nombre
                            }).ToList(),

                Orden = (from o in _context.Ordenes
                            join te in _context.TipoEstados on e.IdTipoEstado equals te.Id
                            where c.Id == IdCliente
                            select new {
                                Orden = o.Id,
                                FechaOrden = o.Fecha,
                                Estado = te.Descripcion,
                                CodEstado = e.IdTipoEstado
                            }).ToList(),

                DetalleOrden = (from d in _context.DetalleOrdenes
                            where c.Id == IdCliente
                            select new {
                                NombrePrenda = d.Prenda.Nombre,
                                CodPrenda = d.IdPrenda,
                                Cantidad = d.CantidadProducir,
                                ValorTotalPesos = (from de in _context.DetalleOrdenes
                                        where c.Id == IdCliente
                                        select new {
                                            SubTotal = (d.CantidadProducir * d.Prenda.ValorUnitCop)
                                        }).Sum(x => x.SubTotal),
                                ValorTotalDolares = (from de in _context.DetalleOrdenes
                                        where c.Id == IdCliente
                                        select new {
                                            SubTotal = (d.CantidadProducir * d.Prenda.ValorUnitUsd)
                                        }).Sum(x => x.SubTotal)
                            }).ToList()
            }).ToListAsync();

        return ordenesPorCliente;
    } 

    public override async Task<IEnumerable<Orden>> GetAllAsync()
    {
        return await _context.Ordenes
            .ToListAsync();
    }

    public override async Task<Orden> GetByIdAsync(int id)
    {
        return await _context.Ordenes
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }

    public override async Task<(int totalRegistros, IEnumerable<Orden> registros)> GetAllAsync(int pageIndez, int pageSize, string search)
    {
        var query = _context.Ordenes as IQueryable<Orden>;

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