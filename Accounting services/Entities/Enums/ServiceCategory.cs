namespace ItServiceAccounting.Entities.Enums;

[Flags]
public enum ServiceCategory
{
    None = 0,

    Support = 1,

    Development = 2,

    Testing = 4,

    Consulting = 8
}
