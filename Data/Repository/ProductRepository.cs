using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data.Repository;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    private readonly DbContext _context;

    public ProductRepository(InventarioContext context) : base(context)
    {
    }
}

