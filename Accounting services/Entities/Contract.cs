namespace ItServiceAccounting.Entities;

public class Contract
{
    public int Id { get; private set; }

    public string Number { get; private set; } = string.Empty;

    public int OrganizationId { get; private set; }

    public int EmployeeId { get; private set; }

    public DateTime SigningDate { get; private set; }

    public decimal TotalAmount { get; private set; }

    public IEnumerable<ServiceContract> ServiceContracts { get; private set; } = [];

    public static Contract CreateOperation(int id, string number, int organizationId, int employeeId,
        IEnumerable<ServiceContract> serviceContracts)
    {
        var elements = serviceContracts ?? [];
        return new Contract
        {
            Id = id,
            Number = number ?? string.Empty,
            OrganizationId = organizationId,
            EmployeeId = employeeId,
            SigningDate = DateTime.Now,
            TotalAmount = elements.Sum(element => element.Price),
            ServiceContracts = elements
        };
    }
}
