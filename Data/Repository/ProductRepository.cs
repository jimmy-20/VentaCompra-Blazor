using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data.Repository;

public class ProductRepository : IProductRepository
{
    private readonly DbContext _context;
    public ProductRepository(InventarioContext context)
    {
        _context = context;   
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
        return await _context.Set<Product>().ToListAsync();
    }

    public Task UpdateItem(Product t)
    {
        throw new NotImplementedException();
    }
}

