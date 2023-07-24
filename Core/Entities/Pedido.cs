namespace Core.Entities;

public class Pedido : BaseEntity
{
    public string IdCliente { get; set; }
    public Cliente Cliente { get; set; }
    public string ArticuloId { get; set; }
    public Articulo  Arituculo { get; set; }
    public int IdDireccion { get; set; }
    public DIreccionCliente DIreccionCliente { get; set; }
    public long Cantidad_Pedido { get; set; }
}