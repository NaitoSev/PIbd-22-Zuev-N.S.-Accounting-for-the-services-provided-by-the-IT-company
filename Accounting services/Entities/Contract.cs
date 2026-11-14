using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ItServiceAccounting.Entities;

public class Contract
{
    protected Contract() { }

    [Key]
    public int Id { get; private set; }

    [Required]
    public string Number { get; private set; } = string.Empty;

    public int OrganizationId { get; private set; }

    public int EmployeeId { get; private set; }

    public DateTime SigningDate { get; private set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalAmount { get; private set; }

    public IReadOnlyCollection<ServiceContract> ServiceContracts => _serviceContracts;

    private readonly List<ServiceContract> _serviceContracts = [];

    [ForeignKey(nameof(OrganizationId))]
    internal Organization Organization { get; private set; } = null!;

    [ForeignKey(nameof(EmployeeId))]
    internal Employee Employee { get; private set; } = null!;

    public static Contract CreateOperation(int id, string number, int organizationId, int employeeId,
        IEnumerable<ServiceContract> serviceContracts)
    {
        var elements = serviceContracts?.ToList() ?? [];
        var contract = new Contract
        {
            Id = id,
            Number = number ?? string.Empty,
            OrganizationId = organizationId,
            EmployeeId = employeeId,
            SigningDate = DateTime.Now,
            TotalAmount = elements.Sum(element => element.Price)
        };
        contract._serviceContracts.AddRange(elements);
        return contract;
    }
}
