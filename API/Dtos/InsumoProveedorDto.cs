namespace API.Dtos;

public class InsumoProveedorDto
{
    public int Id { get; set; }
    public int IdInsumo { get; set; }
    public InsumoDto Insumo { get; set; }
    public int IdProveedor { get; set; }
    public ProveedorDto Proveedor { get; set; }
}