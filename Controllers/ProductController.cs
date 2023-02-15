using InventarioBlazor.Data.Repository;
using InventarioBlazor.Models;

namespace InventarioBlazor.Controllers;

public class ProductoController : GenericController<Producto, IRepository<Producto>>
{
    public ProductoController(IRepository<Producto> repository) : base(repository)
    {
    }
}
