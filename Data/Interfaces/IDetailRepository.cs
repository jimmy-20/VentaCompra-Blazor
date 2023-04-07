namespace Data.Interfaces;
public interface IDetailRepository<T>
    where T : class
{
    Task AddDetail(T t);
}
