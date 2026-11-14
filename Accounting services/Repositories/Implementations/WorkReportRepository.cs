using ItServiceAccounting.Data;
using ItServiceAccounting.Entities;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace ItServiceAccounting.Repositories.Implementations;

internal sealed class WorkReportRepository(DataContext context, ILogger logger)
    : Repository(context, logger), IWorkReportRepository
{
    public IEnumerable<WorkReport> ReadWorkReports(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? contractId = null, int? employeeId = null) =>
        Execute(nameof(ReadWorkReports), new { dateFrom, dateTo, contractId, employeeId }, () =>
        {
            IQueryable<WorkReport> query = Context.WorkReports.AsNoTracking();
            if (dateFrom.HasValue)
                query = query.Where(x => x.ReportDate >= dateFrom.Value);
            if (dateTo.HasValue)
                query = query.Where(x => x.ReportDate <= dateTo.Value);
            if (contractId.HasValue)
                query = query.Where(x => x.ContractId == contractId.Value);
            if (employeeId.HasValue)
                query = query.Where(x => x.EmployeeId == employeeId.Value);

            return query.OrderByDescending(x => x.ReportDate).ThenByDescending(x => x.Id).ToList();
        });

    public void CreateWorkReport(WorkReport report) =>
        Execute(nameof(CreateWorkReport), new { report.ContractId, report.EmployeeId, report.CompletionPercent }, () =>
        {
            Context.WorkReports.Add(report);
            var saved = Context.SaveChanges();
            return new { report.Id, Saved = saved };
        });
}
