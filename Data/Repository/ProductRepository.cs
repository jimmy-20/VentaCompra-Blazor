using InventarioBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace InventarioBlazor.Data.Repository;
public class ProductRepository : GenericRepository<Producto, DbContext>
{
    private readonly DbContext context;
    public ProductRepository(DbContext _context) : base(_context)
    {
        context = _context;
    }
}
