using Data.Interfaces;
using Models;

namespace Data.Repository;

public class ProviderRepository : GenericRepository<Provider>, IProviderRepository
{
    public ProviderRepository(InventarioContext context) : base(context)
    {
    }
}
