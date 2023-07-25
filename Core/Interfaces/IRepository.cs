using System.Linq.Expressions;

namespace Core.Entities;


public interface IRepository<T>
{

    Task<T> GetByIdAsync(string id);
    Task<IEnumerable<T>> GetAll();
    IEnumerable<T> Find(Expression<Func<T,bool>> expression);
    void Add(T entity);
    void AddRange(T entities);
    void Remove(T entity);
    void RemoveAll(IEnumerable<T> entities);
    void Update(T entity);

}