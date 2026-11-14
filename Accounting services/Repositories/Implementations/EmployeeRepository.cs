using ItServiceAccounting.Data;
using ItServiceAccounting.Entities;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace ItServiceAccounting.Repositories.Implementations;

internal sealed class EmployeeRepository(DataContext context, ILogger logger)
    : Repository(context, logger), IEmployeeRepository
{
    public IEnumerable<Employee> ReadEmployees() =>
        Execute(nameof(ReadEmployees), new { }, () =>
            Context.Employees.AsNoTracking().OrderBy(x => x.Id).ToList());

    public Employee ReadEmployeeById(int id) =>
        Execute(nameof(ReadEmployeeById), new { id }, () =>
            Context.Employees.AsNoTracking().SingleOrDefault(x => x.Id == id)
            ?? throw new KeyNotFoundException("Запись справочника не найдена."));

    public void CreateEmployee(Employee employee) =>
        Execute(nameof(CreateEmployee), new { employee.Id, employee.FirstName, employee.LastName, employee.EmployeePost }, () =>
        {
            Context.Employees.Add(employee);
            var saved = Context.SaveChanges();
            return new { employee.Id, Saved = saved };
        });

    public void UpdateEmployee(Employee employee) =>
        Execute(nameof(UpdateEmployee), new { employee.Id, employee.FirstName, employee.LastName, employee.EmployeePost }, () =>
        {
            var current = Context.Employees.Find(employee.Id)
                ?? throw new KeyNotFoundException("Запись справочника не найдена.");
            Context.Entry(current).CurrentValues.SetValues(employee);
            return Context.SaveChanges();
        });

    public void DeleteEmployee(int id) =>
        Execute(nameof(DeleteEmployee), new { id }, () =>
        {
            if (Context.Contracts.Any(x => x.EmployeeId == id) || Context.WorkReports.Any(x => x.EmployeeId == id))
            {
                throw new InvalidOperationException("Запись используется в договорах или отчётах.");
            }

            var current = Context.Employees.Find(id)
                ?? throw new KeyNotFoundException("Запись справочника не найдена.");
            Context.Employees.Remove(current);
            return Context.SaveChanges();
        });
}
