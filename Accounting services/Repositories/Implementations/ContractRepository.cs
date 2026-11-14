using ItServiceAccounting.Data;
using ItServiceAccounting.Entities;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace ItServiceAccounting.Repositories.Implementations;

internal sealed class ContractRepository(DataContext context, ILogger logger)
    : Repository(context, logger), IContractRepository
{
    public IEnumerable<Contract> ReadContracts(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? organizationId = null, int? employeeId = null) =>
        Execute(nameof(ReadContracts), new { dateFrom, dateTo, organizationId, employeeId }, () =>
        {
            IQueryable<Contract> query = Context.Contracts.AsNoTracking().Include(x => x.ServiceContracts);
            if (dateFrom.HasValue)
                query = query.Where(x => x.SigningDate >= dateFrom.Value);
            if (dateTo.HasValue)
                query = query.Where(x => x.SigningDate <= dateTo.Value);
            if (organizationId.HasValue)
                query = query.Where(x => x.OrganizationId == organizationId.Value);
            if (employeeId.HasValue)
                query = query.Where(x => x.EmployeeId == employeeId.Value);

            return query.OrderByDescending(x => x.SigningDate).ThenByDescending(x => x.Id).ToList();
        });

    public void CreateContract(Contract contract) =>
        Execute(nameof(CreateContract), new
        {
            contract.Number, contract.OrganizationId, contract.EmployeeId,
            Services = contract.ServiceContracts.Select(x => new { x.ServiceId, x.Price, x.DurationDays }).ToArray()
        }, () =>
        {
            using var transaction = Context.Database.BeginTransaction();
            Context.Contracts.Add(contract);
            var saved = Context.SaveChanges();
            transaction.Commit();
            return new { contract.Id, Saved = saved };
        });

    public void DeleteContract(int id) =>
        Execute(nameof(DeleteContract), new { id }, () =>
        {
            using var transaction = Context.Database.BeginTransaction();
            if (Context.WorkReports.Any(x => x.ContractId == id))
                throw new InvalidOperationException("Нельзя удалить договор, по которому есть отчёты.");

            var contract = Context.Contracts.Find(id)
                ?? throw new KeyNotFoundException("Договор не найден.");
            Context.Contracts.Remove(contract);
            var saved = Context.SaveChanges();
            transaction.Commit();
            return saved;
        });
}
