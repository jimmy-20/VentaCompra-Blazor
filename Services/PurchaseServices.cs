using Data.Interfaces;
using Models;
using Services.Interfaces;

namespace Services;

public class PurchaseServices : GenericServices<Purchase>, IPurchaseServices
{
    public PurchaseServices(IPurchaseRepository repository) : base(repository)
    {
    }
}
