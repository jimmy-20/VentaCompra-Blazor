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
        throw new NotImplementedException();
    }

    public async Task<TEntity> FindItem(int id)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<List<TEntity>> GetAll() {
        return await _context.Set<TEntity>().ToListAsync();
    }

    public async Task UpdateItem(TEntity t)
    {
        throw new NotImplementedException();
    }
}
