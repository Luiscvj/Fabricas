namespace Core.Entities;

public class Cliente : BaseEntity
{
   
    public decimal Saldo { get; set; }
    public decimal Limit_Credito { get; set; }
    public ICollection<DIreccionCliente> DIreccionClientes { get; set; }
    public ICollection<Pedido> Pedidos { get; set; }
  
}