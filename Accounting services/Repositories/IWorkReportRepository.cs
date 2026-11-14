using ItServiceAccounting.Entities;

namespace ItServiceAccounting.Repositories;

public interface IWorkReportRepository
{
    IEnumerable<WorkReport> ReadWorkReports(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? contractId = null, int? employeeId = null);

    void CreateWorkReport(WorkReport workReport);
}
