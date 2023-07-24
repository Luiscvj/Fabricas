namespace Core.Entities;

public class Articulo : BaseEntity
{
    public string Description { get; set; }
    public ICollection<Fabrica> Fabricas { get; set; }
    public ICollection<FabricaArticulo> FabricaArticulos { get; set; }

     public ICollection<Pedido> Pedidos { get; set; }
}
