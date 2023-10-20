namespace Dominio.Entities;

public class DetalleVenta : BaseEntity
{
    public int IdVenta { get; set; }
    public Venta Venta { get; set; }
    public int IdProducto { get; set; }
    public Inventario Producto { get; set; }
    public int IdTalla { get; set; }
    public Talla Talla { get; set; }
    public int Cantidad { get; set; }
    public double ValorUnit { get; set; }
}