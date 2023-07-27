using ApplicationCore.Interfaces.Repository;
using Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repository;

public class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected ApplicationDbContext _context { get; set; }

    public RepositoryBase(
        ApplicationDbContext context
        )
    {
        _context = context;
    }

    public async Task<int> Create(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        return await _context.SaveChangesAsync();
    }

    public async Task<bool> Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
        int count = await _context.SaveChangesAsync();
        return count > 0;
    }

    public IQueryable<T> Get(Expression<Func<T, bool>> expression)
    {
        return _context.Set<T>().Where(expression).AsNoTracking();
    }

    public IQueryable<T> GetAll()
    {
        return _context.Set<T>().AsNoTracking();
    }

    public async Task<bool> Update(T entity)
    {
        _context.Update(entity);
        int count = await _context.SaveChangesAsync();
        return count > 0;
    }
}