using ItServiceAccounting.Entities;
using ItServiceAccounting.Entities.Enums;

namespace ItServiceAccounting.Repositories.Implementations;

internal class EmployeeRepository : IEmployeeRepository
{
    public void CreateEmployee(Employee employee)
    {
    }

    public void DeleteEmployee(int id)
    {
    }

    public Employee ReadEmployeeById(int id)
    {
        return Employee.CreateEntity(0, string.Empty, string.Empty, EmployeePost.None);
    }

    public IEnumerable<Employee> ReadEmployees()
    {
        return [];
    }

    public void UpdateEmployee(Employee employee)
    {
    }
}
