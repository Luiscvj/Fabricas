namespace Core.Entities;

public class DIreccionCliente 
{      
    public int Id { get; set; }
    public string Direccion { get; set; }
    public string IdCliente  { get; set; }
    public Cliente Cliente{ get; set; }
    public ICollection<Pedido> Pedidos { get; set; }
}