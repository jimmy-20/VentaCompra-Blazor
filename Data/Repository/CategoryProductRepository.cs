using Data.Interfaces;
using Models;

namespace Data.Repository;

public class CategoryProductRepository : GenericRepository<Category>, ICategoryProductRepository
{
    public CategoryProductRepository(InventarioContext context) : base(context)
    {
    }
}
