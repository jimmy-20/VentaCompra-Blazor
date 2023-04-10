using Data.Interfaces;
using Models;
using Services.Interfaces;

namespace Services;

public class ProviderServices : GenericServices<Provider>, IProviderServices
{
    public ProviderServices(IProviderRepository repository) : base(repository)
    {
    }
}
