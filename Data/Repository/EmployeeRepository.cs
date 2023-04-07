using Data.Interfaces;
using Models;

namespace Data.Repository;
public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
{
    public EmployeeRepository(InventarioContext context) : base(context)
    {
    }
}
