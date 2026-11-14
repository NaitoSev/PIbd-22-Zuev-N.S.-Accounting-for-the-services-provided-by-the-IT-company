using ItServiceAccounting.Entities;

namespace ItServiceAccounting.Repositories;

public interface IOrganizationRepository
{
    IEnumerable<Organization> ReadOrganizations();

    Organization ReadOrganizationById(int id);

    void CreateOrganization(Organization organization);

    void UpdateOrganization(Organization organization);

    void DeleteOrganization(int id);
}
