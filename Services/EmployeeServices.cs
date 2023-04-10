using Data.Interfaces;
using Models;
using Services.Interfaces;

namespace Services;

public class EmployeeServices : GenericServices<Employee>, IEmployeeServices
{
    public EmployeeServices(IEmployeeRepository repository) : base(repository)
    {
    }
}
