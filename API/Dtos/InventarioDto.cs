namespace API.Dtos;

public class InventarioDto
{
    public int Id { get; set; }
    public string CodInv { get; set; }
    public int IdPrenda { get; set; }
    public PrendaDto Prenda { get; set; }
    public double ValorVtaCop { get; set; }
    public double ValorVtaUsd { get; set; }
}