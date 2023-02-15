using InventarioBlazor.Data.Repository;
using InventarioBlazor.Models;

namespace InventarioBlazor.Controllers;

public abstract class GenericController<TEntity,TRepository> 
    where TEntity: class
    where TRepository : IRepository<TEntity>
{
    private readonly IRepository<TEntity> _repository;
    public GenericController(IRepository<TEntity> repository)
    {
        _repository = repository;
    }

    public virtual async Task<IEnumerable<TEntity>> GetAll(){
        return await _repository.GetAll();
    }
    
}