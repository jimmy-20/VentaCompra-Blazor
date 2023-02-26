using Data.Interfaces;
using Data.Repository;
using Models;

namespace Services;

public class ProductServices : IProductServices
{
    private readonly IProductRepository _repository;

    public ProductServices(IProductRepository repository)
    {
        _repository = repository;
    }
    public Task AddItem(Product t)
    {
        throw new NotImplementedException();
    }

    public Task<Product> FindItem(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Product>> GetAll()
    {
        return await _repository.GetAll();
    }

    public Task UpdateItem(Product t)
    {
        throw new NotImplementedException();
    }
}