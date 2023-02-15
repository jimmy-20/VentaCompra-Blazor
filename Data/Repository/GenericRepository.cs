using Microsoft.EntityFrameworkCore;

namespace InventarioBlazor.Data.Repository;

public abstract class GenericRepository<TEntity, TContext> : IRepository<TEntity>
    where TEntity : class
    where TContext : DbContext
{

    private readonly TContext context;

    public GenericRepository(TContext _context)
    {
        context = _context;
    }
    public async Task<TEntity> Add(TEntity t)
    {
        context.Add(t);
        await context.SaveChangesAsync();
        return t;
    }

    public async Task<TEntity> Find(int id)
    {
        return await context.Set<TEntity>().FindAsync(id);
    }

    public virtual async Task<IEnumerable<TEntity>> GetAll()
    {
        return await context.Set<TEntity>().ToListAsync();
    }

    public async Task<TEntity> Update(TEntity t)
    {
        context.Update(t);
        await context.SaveChangesAsync();
        return t;
    }
}
