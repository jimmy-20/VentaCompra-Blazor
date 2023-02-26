using Data.Interfaces;
using Data.Repository;
using Models;

namespace Services;

public class ProductServices : GenericServices<Product>, IProductServices
{
    private readonly IProductRepository _repository;
    public ProductServices(IProductRepository repository) : base(repository)
    {
        _repository = repository;
    }
}