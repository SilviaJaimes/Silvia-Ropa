namespace Dominio.Entities;

public class TipoProteccion : BaseEntity
{
    public string Descripcion { get; set; }

    public ICollection<Prenda> Prendas { get; set; }
}