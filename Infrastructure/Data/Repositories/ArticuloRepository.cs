using Core.Entities;

namespace Infrastructure.Data.Repositories;


public class ArticuloRepository : BaseRepository<Articulo>
{
    public ArticuloRepository(FabricaContext context) : base(context)
    {
    }

   public override  void Add(Articulo entity)
   {
        //Implemento una sobrecarga 


   }
}