using Data.Interfaces;
using Models;

namespace Data.Repository;

public class PurchaseRepository : GenericRepository<Purchase>, IPurchaseRepository
{
    public PurchaseRepository(InventarioContext context) : base(context)
    {
    }
}
