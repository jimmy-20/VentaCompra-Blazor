using Data.Interfaces;
using Models;

namespace Data.Repository;

public class BaseProductRepository : GenericRepository<BaseProduct>, IBaseProductRepository
{
    public BaseProductRepository(InventarioContext context) : base(context)
    {
    }
}
