using ItServiceAccounting.Entities;
using ItServiceAccounting.Entities.Enums;

namespace ItServiceAccounting.Repositories.Implementations;

internal class ServiceRepository : IServiceRepository
{
    public void CreateService(Service service)
    {
    }

    public void DeleteService(int id)
    {
    }

    public Service ReadServiceById(int id)
    {
        return Service.CreateEntity(0, string.Empty, ServiceCategory.None, string.Empty);
    }

    public IEnumerable<Service> ReadServices()
    {
        return [];
    }

    public void UpdateService(Service service)
    {
    }
}
