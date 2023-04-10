using Data.Interfaces;
using Models;
using Services.Interfaces;

namespace Services;
public class CustomerServices : GenericServices<Customer>, ICustomerServices
{
    public CustomerServices(ICustomerRepository repository) : base(repository)
    {
    }
}
