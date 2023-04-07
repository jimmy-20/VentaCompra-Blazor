using Data.Interfaces;

namespace Data.Repository;

public class DetailRepository<TEntity> : IDetailRepository<TEntity>
    where TEntity : class
{
    private readonly InventarioContext _context;
    public DetailRepository(InventarioContext context)
    {
        _context = context;
    }
    
    public async Task AddDetail(TEntity t)
    {
        await _context.Set<TEntity>().AddAsync(t);
    }
}
