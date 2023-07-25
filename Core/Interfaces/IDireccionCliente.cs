using System.Linq.Expressions;

namespace Core.Entities;


public interface IDireccionCliente
{

    Task GetByIdAsync(string id);
    Task GetAll();
    IEnumerable<DIreccionCliente> Find(Expression<Func<DIreccionCliente,bool>> expression);
    void Add(DIreccionCliente entity);
    void AddRange(DIreccionCliente entities);
    void Remove(DIreccionCliente entity);
    void RemoveAll(IEnumerable<DIreccionCliente> entities);
    void Update(DIreccionCliente entity);

}