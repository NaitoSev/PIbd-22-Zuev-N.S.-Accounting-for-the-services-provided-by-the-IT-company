namespace ItServiceAccounting.Entities;

public class Organization
{
    public int Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string Inn { get; private set; } = string.Empty;

    public string ContactPerson { get; private set; } = string.Empty;

    public string Phone { get; private set; } = string.Empty;

    public static Organization CreateEntity(int id, string name, string inn, string contactPerson, string phone)
    {
        return new Organization
        {
            Id = id,
            Name = name ?? string.Empty,
            Inn = inn ?? string.Empty,
            ContactPerson = contactPerson ?? string.Empty,
            Phone = phone ?? string.Empty
        };
    }
}
