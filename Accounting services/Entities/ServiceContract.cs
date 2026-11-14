using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ItServiceAccounting.Entities;

public class ServiceContract
{
    protected ServiceContract() { }

    [Key]
    public int Id { get; private set; }

    public int ContractId { get; private set; }

    public int ServiceId { get; private set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; private set; }

    public int DurationDays { get; private set; }

    [ForeignKey(nameof(ServiceId))]
    internal Service Service { get; private set; } = null!;

    [ForeignKey(nameof(ContractId))]
    internal Contract Contract { get; private set; } = null!;

    public static ServiceContract CreateElement(int id, int serviceId, decimal price, int durationDays)
    {
        return new ServiceContract
        {
            Id = id,
            ServiceId = serviceId,
            Price = price,
            DurationDays = durationDays
        };
    }
}
