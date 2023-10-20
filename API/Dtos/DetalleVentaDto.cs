namespace API.Dtos;

public class DetalleVentaDto
{
    public int Id { get; set; }
    public int IdVenta { get; set; }
    public VentaDto Venta { get; set; }
    public int IdProducto { get; set; }
    public InventarioDto Producto { get; set; }
    public int IdTalla { get; set; }
    public TallaDto Talla { get; set; }
    public int Cantidad { get; set; }
    public double ValorUnit { get; set; }
}