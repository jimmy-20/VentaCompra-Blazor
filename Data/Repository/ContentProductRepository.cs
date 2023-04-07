using Data.Interfaces;
using Models;

namespace Data.Repository;

public class ContentProductRepository : GenericRepository<ContentProduct>, IContentProductRepository
{
    public ContentProductRepository(InventarioContext context) : base(context)
    {
    }
}
