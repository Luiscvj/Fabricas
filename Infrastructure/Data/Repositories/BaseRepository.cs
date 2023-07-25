using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories;

//Con el where lo que le indico es que cualqueir clase que use mi repositorio debe heredar de mi clase BaseEntity.
public class BaseRepository<T> : IRepository<T> where T : BaseEntity
{       
    protected readonly FabricaContext _context;

    public BaseRepository(FabricaContext context)
    {
        _context = context;
    }

    public virtual  void Add(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public virtual void AddRange(T entities)
    {
        _context.Set<T>().AddRange(entities);
    }

    public virtual IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> expression)
    {
        return _context.Set<T>().Where(expression).ToList();
    }
    public virtual async  Task<IEnumerable<T>> GetAll()
    {
        return await _context.Set<T>().ToListAsync();
        
    }

    public virtual async Task<T> GetByIdAsync(string id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public virtual void Remove(T entity)
    {
       _context.Set<T>().Remove(entity);
    }

    public virtual void RemoveAll(IEnumerable<T> entities)
    {
        _context.Set<T>().RemoveRange(entities);
    }

    public virtual void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }
}
