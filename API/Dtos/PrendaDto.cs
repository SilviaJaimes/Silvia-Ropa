namespace API.Dtos;

public class PrendaDto
{
    public int Id { get; set; }
    public string IdPrenda { get; set; }
    public string Nombre { get; set; }
    public double ValorUnitCop { get; set; }
    public double ValorUnitUsd { get; set; }
    public int IdEstado { get; set; }
    public EstadoDto Estado { get; set; }
    public int IdTipoProteccion { get; set; }
    public TipoProteccionDto TipoProteccion { get; set; }
    public int IdGenero { get; set; }
    public GeneroDto Genero { get; set; }
}