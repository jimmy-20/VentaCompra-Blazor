using Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository;

public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity>
    where TEntity : class
{
    private readonly DbContext _context;
    public GenericRepository(InventarioContext context)
    {
        _context = context;
    }
    public async Task AddItem(TEntity t)
    {
        await _context.Set<TEntity>().AddAsync(t);
        await _context.SaveChangesAsync();
    }

    public async Task<TEntity>? FindItem(int id) => await _context.Set<TEntity>().FindAsync(id);

    public virtual async Task<List<TEntity>> GetAll() => await _context.Set<TEntity>().ToListAsync();

    public async Task UpdateItem(TEntity t)
    {
        _context.Set<TEntity>().Update(t);
        await _context.SaveChangesAsync();
    }
}
