namespace API.Dtos;

public class EmpleadoDto
{
    public int Id { get; set; }
    public string IdEmpleado { get; set; }
    public string Nombre { get; set; }
    public int IdCargo { get; set; }
    public CargoDto Cargo { get; set; }
    public DateOnly FechaIngreso { get; set; }
    public int IdMunicipio { get; set; }
    public MunicipioDto Municipio { get; set; }
}