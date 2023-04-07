using Data.Interfaces;
using Models;

namespace Data.Repository;

public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(InventarioContext context) : base(context)
    {
    }
}
