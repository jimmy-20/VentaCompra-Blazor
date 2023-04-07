using Data.Interfaces;
using Models;

namespace Data.Repository;

public class OrderDetailRepository : DetailRepository<Order_Detail>, IOrderDetailRepository
{
    public OrderDetailRepository(InventarioContext context) : base(context)
    {
    }
}
