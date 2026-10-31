using ItServiceAccounting.Entities;


namespace ItServiceAccounting.Repositories.Implementations;

internal class OrganizationRepository : IOrganizationRepository
{
    public void CreateOrganization(Organization organization)
    {
    }

    public void DeleteOrganization(int id)
    {
    }

    public Organization ReadOrganizationById(int id)
    {
        return Organization.CreateEntity(0, string.Empty, string.Empty, string.Empty, string.Empty);
    }

    public IEnumerable<Organization> ReadOrganizations()
    {
        return [];
    }

    public void UpdateOrganization(Organization organization)
    {
    }
}
