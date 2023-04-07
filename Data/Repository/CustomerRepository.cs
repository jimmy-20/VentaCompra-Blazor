using Data.Interfaces;
using Models;

namespace Data.Repository;

public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(InventarioContext context) : base(context)
    {
    }
}
