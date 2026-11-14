namespace ItServiceAccounting.Entities;

public class WorkReport
{
    public int Id { get; private set; }

    public int ContractId { get; private set; }

    public int EmployeeId { get; private set; }

    public DateTime ReportDate { get; private set; }

    public int CompletionPercent { get; private set; }

    public string Description { get; private set; } = string.Empty;

    public static WorkReport CreateOperation(int id, int contractId, int employeeId, int completionPercent,
        string description)
    {
        return new WorkReport
        {
            Id = id,
            ContractId = contractId,
            EmployeeId = employeeId,
            ReportDate = DateTime.Now,
            CompletionPercent = completionPercent,
            Description = description ?? string.Empty
        };
    }
}
