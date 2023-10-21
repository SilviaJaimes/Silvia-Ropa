using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class VentaRepository : GenericRepository<Venta>, IVenta
{
    private readonly ApiContext _context;

    public VentaRepository(ApiContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Object>> VentaPorEmpleado(int IdEmpleado)
    {
        var ordenesPorCliente = await (
            from d in _context.DetalleVentas
            join v in _context.Ventas on d.IdVenta equals v.Id
            join e in _context.Empleados on v.IdEmpleado equals e.Id
            where e.Id == IdEmpleado 
            select new 
            {
                IdEmpleado = e.Id,
                Nombre = e.Nombre,

                Factura = (from v in _context.Ventas
                            where e.Id == IdEmpleado
                            select new {
                                NroFactura = v.Id,
                                Fecha = v.Fecha,
                                Total = (from d in _context.DetalleVentas
                                        where e.Id == IdEmpleado
                                        select new {
                                            SubTotal = (d.Cantidad * d.ValorUnit)
                                        }).Sum(x => x.SubTotal)
                            }).ToList()
            }).ToListAsync();

        return ordenesPorCliente;
    } 

    public override async Task<IEnumerable<Venta>> GetAllAsync()
    {
        return await _context.Ventas
            .ToListAsync();
    }

    public override async Task<Venta> GetByIdAsync(int id)
    {
        return await _context.Ventas
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }

    public override async Task<(int totalRegistros, IEnumerable<Venta> registros)> GetAllAsync(int pageIndez, int pageSize, string search)
    {
        var query = _context.Ventas as IQueryable<Venta>;

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