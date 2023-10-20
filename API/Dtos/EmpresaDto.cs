namespace API.Dtos;

public class EmpresaDto
{
    public int Id { get; set; }
    public string Nit { get; set; }
    public string RazonSocial { get; set; }
    public string RepresentanteLegal { get; set; }
    public DateOnly FechaCreacion { get; set; }
    public int IdMunicipio { get; set; }
    public MunicipioDto Municipio { get; set; }
}