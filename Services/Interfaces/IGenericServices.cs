namespace Services.Interfaces;
public interface IGenericServices<TEntity>
    where TEntity: class
{
    Task AddItem(TEntity t);
    Task UpdateItem(TEntity t);
    Task<List<TEntity>> GetAll();
    Task<TEntity> FindItem(int id);
}
