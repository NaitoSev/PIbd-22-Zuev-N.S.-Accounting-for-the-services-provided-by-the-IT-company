using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ItServiceAccounting.Entities;

public class WorkReport
{
    protected WorkReport() { }

    [Key]
    public int Id { get; private set; }

    public int ContractId { get; private set; }

    public int EmployeeId { get; private set; }

    public DateTime ReportDate { get; private set; }

    public int CompletionPercent { get; private set; }

    public string Description { get; private set; } = string.Empty;

    [ForeignKey(nameof(EmployeeId))]
    internal Employee Employee { get; private set; } = null!;

    [ForeignKey(nameof(ContractId))]
    internal Contract Contract { get; private set; } = null!;

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
