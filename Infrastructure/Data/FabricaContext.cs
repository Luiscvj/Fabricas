using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class FabricaContext :DbContext
{
    public FabricaContext(DbContextOptions<FabricaContext> options) : base(options)
    {

    }


    public DbSet<Articulo> Articulos {get; set;}
    public DbSet<Pedido> Pedidos {get; set;}


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}