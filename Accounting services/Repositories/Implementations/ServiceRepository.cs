using ItServiceAccounting.Data;
using ItServiceAccounting.Entities;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace ItServiceAccounting.Repositories.Implementations;

internal sealed class ServiceRepository(DataContext context, ILogger logger)
    : Repository(context, logger), IServiceRepository
{
    public IEnumerable<Service> ReadServices() =>
        Execute(nameof(ReadServices), new { }, () =>
            Context.Services.AsNoTracking().OrderBy(x => x.Id).ToList());

    public Service ReadServiceById(int id) =>
        Execute(nameof(ReadServiceById), new { id }, () =>
            Context.Services.AsNoTracking().SingleOrDefault(x => x.Id == id)
            ?? throw new KeyNotFoundException("Запись справочника не найдена."));

    public void CreateService(Service service) =>
        Execute(nameof(CreateService), new { service.Id, service.Name, service.ServiceCategory }, () =>
        {
            Context.Services.Add(service);
            var saved = Context.SaveChanges();
            return new { service.Id, Saved = saved };
        });

    public void UpdateService(Service service) =>
        Execute(nameof(UpdateService), new { service.Id, service.Name, service.ServiceCategory }, () =>
        {
            var current = Context.Services.Find(service.Id)
                ?? throw new KeyNotFoundException("Запись справочника не найдена.");
            Context.Entry(current).CurrentValues.SetValues(service);
            return Context.SaveChanges();
        });

    public void DeleteService(int id) =>
        Execute(nameof(DeleteService), new { id }, () =>
        {
            if (Context.ServiceContracts.Any(x => x.ServiceId == id))
            {
                throw new InvalidOperationException("Запись используется в договорах или отчётах.");
            }

            var current = Context.Services.Find(id)
                ?? throw new KeyNotFoundException("Запись справочника не найдена.");
            Context.Services.Remove(current);
            return Context.SaveChanges();
        });
}
