namespace API.Dtos;

public class DetalleOrdenDto
{
    public int Id { get; set; }
    public int IdOrden { get; set; }
    public OrdenDto Orden { get; set; }
    public int IdPrenda { get; set; }
    public PrendaDto Prenda { get; set; }
    public int CantidadProducir { get; set; }
    public int IdColor { get; set; }
    public ColorDto Color { get; set; }
    public int CantidadProducida { get; set; }
    public int IdEstado { get; set; }
    public EstadoDto Estado { get; set; }
}