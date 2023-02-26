using Data.Interfaces;
using Data.Repository;
using Models;

namespace Services;

public class ProductServices : GenericServices<Product>
{
    public ProductServices(IGenericRepository<Product> repository) : base(repository)
    {
    }
}