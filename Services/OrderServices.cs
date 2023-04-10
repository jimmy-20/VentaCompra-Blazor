using Data.Interfaces;
using Models;
using Services.Interfaces;

namespace Services;

public class OrderServices : GenericServices<Order>, IOrderServices
{
    public OrderServices(IOrderRepository repository) : base(repository)
    {
    }
}
