namespace API.Dtos;

public class MunicipioDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int IdDep { get; set;}
    public DepartamentoDto Departamento { get; set; }
}