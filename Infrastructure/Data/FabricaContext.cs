using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class FabricaContext :DbContext
{
    public FabricaContext(DbContextOptions<FabricaContext> options) : base(options)
    {

    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}