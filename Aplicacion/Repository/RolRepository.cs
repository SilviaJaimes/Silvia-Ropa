using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class RolRepository : GenericRepository<Rol>, IRol
{
    private readonly ApiContext _context;

    public RolRepository(ApiContext context) : base(context)
    {
        _context = context;
    }

    /* public async Task<IEnumerable<Object>> MedicamentoLaboratorio(string Laboratorio)
    {
        var medicamentoLaboratorio = await (
            from m in _context.Medicamentos
            join l in _context.Laboratorios on m.IdLaboratorioFk equals l.Id
            where l.Nombre.ToLower() == Laboratorio.ToLower() 
            select new 
            {
                Nombre = m.Nombre,
                Laboratorio = l.Nombre
            }).ToListAsync();

        return medicamentoLaboratorio;
    } */

    /* public async Task<(int totalRegistros, IEnumerable<Object> registros)> MedicamentoLaboratorioPaginated(string Laboratorio, int pageIndex, int pageSize, string search = null)
    {
        // Obtener la consulta base.
        var query = from m in _context.Medicamentos
                    join l in _context.Laboratorios on m.IdLaboratorioFk equals l.Id
                    where l.Nombre.ToLower() == Laboratorio.ToLower()
                    select new 
                    {
                        Nombre = m.Nombre,
                        Laboratorio = l.Nombre
                    };

        // Aplicar búsqueda si se proporciona el término de búsqueda.
        if (!string.IsNullOrEmpty(search))
        {
            var lowerSearch = search.ToLower();
            query = query.Where(m => m.Nombre.ToLower().Contains(lowerSearch) || m.Laboratorio.ToLower().Contains(lowerSearch));
        }

        // Obtener el total de registros de la consulta.
        int totalRegistros = await query.CountAsync();

        // Aplicar la paginación a la consulta.
        var registros = await query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (totalRegistros, registros);
    } */

    /* public async Task<(int totalRegistros, IEnumerable<Object> registros)> MascotasPorEspeciePaginated(int pageIndex, int pageSize, string search = null)
    {
        var query = from ma in _context.Mascotas
                    join r in _context.Razas on ma.IdRazaFk equals r.Id
                    group ma by r.Especie into especies
                    select new
                    {
                        Especie = especies.Key,
                        Mascotas = especies.Select(mascota => new 
                        {
                            Id = mascota.Id,
                            Nombre = mascota.Nombre,
                            Especie = mascota.Raza.Especie.Nombre
                        }).ToList()
                    };

        if (!string.IsNullOrEmpty(search))
        {
            var lowerSearch = search.ToLower();
            query = query.Where(m => m.Especie.Nombre.ToLower().Contains(lowerSearch));
        }

        int totalRegistros = await query.CountAsync();

        var registros = await query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (totalRegistros, registros);
    } */

    /* public async Task<IEnumerable<object>> MascotasVacunadas2023()
    {
        int year = 2023; 
        DateTime primerTrimestreInicio = new DateTime(year, 1, 1); 
        DateTime primerTrimestreFin = new DateTime(year, 3, 31); 

        var Vacunadas = await (
            from c in _context.Citas
            join m in _context.Mascotas on c.IdMascotaFk equals m.Id

            where c.Motivo == "Vacunación" && 
                c.Hora >= primerTrimestreInicio && c.Hora <= primerTrimestreFin

            select new{
                NombreMascota = m.Nombre,
                Motivo = c.Motivo,
                FechaNacimientoMascota = m.FechaNacimiento,
                FechaCita = c.Hora
            }).Distinct()
            .ToListAsync();
        return Vacunadas;
    } */

    /* public async Task<IEnumerable<object>> MascotasPorEspecie()
    {
        return await (
            from ma in _context.Mascotas
            join r in _context.Razas on ma.IdRazaFk equals r.Id
            group ma by r.Especie into especies
            select new
            {
                Especie = especies.Key,
                Mascotas = especies.Select(mascota => new 
                {
                    Id = mascota.Id,
                    Nombre = mascota.Nombre,
                    Especie = mascota.Raza.Especie.Nombre
                }).ToList()
            }
        ).ToListAsync();
    } */
    public override async Task<IEnumerable<Rol>> GetAllAsync()
    {
        return await _context.Roles
            .ToListAsync();
    }

    public override async Task<Rol> GetByIdAsync(int id)
    {
        return await _context.Roles
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }

    public override async Task<(int totalRegistros, IEnumerable<Rol> registros)> GetAllAsync(int pageIndez, int pageSize, string search)
    {
        var query = _context.Roles as IQueryable<Rol>;

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