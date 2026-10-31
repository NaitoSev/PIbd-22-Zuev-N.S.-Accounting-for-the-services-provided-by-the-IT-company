using ItServiceAccounting.Entities;

namespace ItServiceAccounting.Repositories.Implementations;

internal class WorkReportRepository : IWorkReportRepository
{
    public void CreateWorkReport(WorkReport workReport)
    {
    }

    public IEnumerable<WorkReport> ReadWorkReports(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? contractId = null, int? employeeId = null)
    {
        return [];
    }
}
