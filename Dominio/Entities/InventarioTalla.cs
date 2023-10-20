namespace Dominio.Entities;

public class InventarioTalla : BaseEntity
{
    public int IdInventario { get; set; }
    public Inventario Inventario { get; set; }
    public int IdTalla { get; set; }
    public Talla Talla { get; set; }
    public int Cantidad { get; set; }
}