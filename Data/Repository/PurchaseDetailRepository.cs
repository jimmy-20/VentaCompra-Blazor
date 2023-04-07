using Data.Interfaces;
using Models;

namespace Data.Repository;

public class PurchaseDetailRepository : DetailRepository<Purchase_Detail>, IPurchaseDetailRepository
{
    public PurchaseDetailRepository(InventarioContext context) : base(context)
    {
    }
}
