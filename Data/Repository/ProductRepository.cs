using Data.Interfaces;
using Models;

namespace Data.Repository;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(InventarioContext context) : base(context)
    {
    }
}

