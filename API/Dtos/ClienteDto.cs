namespace API.Dtos;

public class ClienteDto
{
    public int Id { get; set; }
    public string IdCliente { get; set; }
    public string Nombre { get; set; }
    public int IdTipoPersona { get; set; }
    public TipoPersonaDto TipoPersona { get; set; }
    public DateOnly FechaRegistro { get; set; }
    public int IdMunicipio { get; set; }
    public MunicipioDto Municipio { get; set; }
}