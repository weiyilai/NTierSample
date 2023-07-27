using System.Linq.Expressions;

namespace ApplicationCore.Interfaces.Repository;

public interface IRepositoryBase<T> where T : class
{
    IQueryable<T> GetAll();
    IQueryable<T> Get(Expression<Func<T, bool>> expression);
    Task<int> Create(T entity);
    Task<bool> Update(T entity);
    Task<bool> Delete(T entity);
}