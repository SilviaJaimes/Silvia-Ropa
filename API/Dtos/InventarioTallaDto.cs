namespace API.Dtos;

public class InventarioTallaDto
{
    public int Id { get; set; }
    public int IdInventario { get; set; }
    public InventarioDto Inventario { get; set; }
    public int IdTalla { get; set; }
    public TallaDto Talla { get; set; }
    public int Cantidad { get; set; }
}