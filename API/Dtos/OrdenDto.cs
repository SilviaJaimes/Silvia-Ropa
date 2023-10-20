namespace API.Dtos;

public class OrdenDto
{
    public int Id { get; set; }
    public DateOnly Fecha { get; set; }
    public int IdEmpleado { get; set; }
    public EmpleadoDto Empleado { get; set; }
    public int IdCliente { get; set; }
    public ClienteDto Cliente { get; set; }
    public int IdEstado { get; set; }
    public EstadoDto Estado { get; set; }
}