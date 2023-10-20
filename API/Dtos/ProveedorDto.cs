namespace API.Dtos;

public class ProveedorDto
{
    public int Id { get; set; }
    public string IdProveedor { get; set; }
    public string Nombre { get; set; }
    public int IdTipoPersona { get; set; }
    public TipoPersonaDto TipoPersona { get; set; }
    public int IdMunicipio { get; set; }
    public MunicipioDto Municipio { get; set; }
}