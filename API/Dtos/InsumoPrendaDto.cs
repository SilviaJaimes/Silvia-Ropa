namespace API.Dtos;

public class InsumoPrendaDto
{
    public int Id { get; set; }
    public int IdInsumo { get; set; }
    public InsumoDto Insumo { get; set; }
    public int IdPrenda { get; set; }
    public PrendaDto Prenda { get; set; }
    public int Cantidad { get; set; }
}