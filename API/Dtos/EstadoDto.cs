namespace API.Dtos;

public class EstadoDto
{
    public int Id { get; set; }    
    public string Descripcion { get; set; }
    public int IdTipoEstado { get; set; }
    public TipoEstadoDto TipoEstado { get; set; }
}