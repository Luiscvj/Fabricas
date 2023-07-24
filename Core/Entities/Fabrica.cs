namespace Core.Entities;

public class Fabrica : BaseEntity
{
    public string Num_Contacto { get; set; }
    public string Email_Contacto { get; set; }
    public long Num_Articulos { get; set; }
    public ICollection<Articulo> Articulos { get; set; }
    public ICollection<FabricaArticulo> FabricaArticulos { get; set; }
}