using ItServiceAccounting.Entities.Enums;

namespace ItServiceAccounting.Entities;

public class Service
{
    public int Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public ServiceCategory ServiceCategory { get; private set; }

    public string Description { get; private set; } = string.Empty;

    public static Service CreateEntity(int id, string name, ServiceCategory serviceCategory, string description)
    {
        return new Service
        {
            Id = id,
            Name = name ?? string.Empty,
            ServiceCategory = serviceCategory,
            Description = description ?? string.Empty
        };
    }
}
