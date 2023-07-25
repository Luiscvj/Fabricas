using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;


public class ArticuloConfiguration : IEntityTypeConfiguration<Articulo>
{
    public void Configure(EntityTypeBuilder<Articulo> builder)
    {
        builder.ToTable("Articulo");

        builder.HasMany( a => a.Fabricas)
        .WithMany(f => f.Articulos)
        .UsingEntity<FabricaArticulo>();
    }
}