namespace ItServiceAccounting.Entities;

public class ServiceContract
{
    public int Id { get; private set; }

    public int ServiceId { get; private set; }

    public decimal Price { get; private set; }

    public int DurationDays { get; private set; }

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
