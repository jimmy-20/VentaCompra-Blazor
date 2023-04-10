using Data.Interfaces;
using Models;
using Services.Interfaces;

namespace Services;

public class CategoryProductServices : GenericServices<Category>, ICategoryProductServices
{
    public CategoryProductServices(ICategoryProductRepository repository) : base(repository)
    {

    }
}
