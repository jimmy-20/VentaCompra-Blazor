namespace InventarioBlazor.Data.Repository; 

public interface IRepository<T>
    where T : class
{
    Task<T> Add(T t);
    Task<IEnumerable<T>> GetAll();
    Task<T> Find(int id);
    Task<T> Update(T t);
}
