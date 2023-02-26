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

    public Task AddItem(TEntity t)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> FindItem(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<TEntity>> GetAll()
    {
        return await _repository.GetAll();
    }

    public Task UpdateItem(TEntity t)
    {
        throw new NotImplementedException();
    }
}

