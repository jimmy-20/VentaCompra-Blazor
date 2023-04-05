using Data.Interfaces;
using Services.Interfaces;

namespace Services;

public abstract class GenericServices<TEntity> : IGenericServices<TEntity>
    where TEntity : class
{
    private readonly IGenericRepository<TEntity> _repository;

    protected GenericServices(IGenericRepository<TEntity> repository)
    {
        _repository = repository;
    }

    public async Task AddItem(TEntity t)
    {
        await _repository.AddItem(t);
    }

    public async Task<TEntity> FindItem(int id)
    {
        return await _repository.FindItem(id);
    }

    public async Task<List<TEntity>> GetAll()
    {
        return await _repository.GetAll();
    }

    public async Task UpdateItem(TEntity t)
    {
        await _repository.UpdateItem(t);
    }
}

