using ItServiceAccounting.Data;
using ItServiceAccounting.Entities;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace ItServiceAccounting.Repositories.Implementations;

internal sealed class OrganizationRepository(DataContext context, ILogger logger)
    : Repository(context, logger), IOrganizationRepository
{
    public IEnumerable<Organization> ReadOrganizations() =>
        Execute(nameof(ReadOrganizations), new { }, () =>
            Context.Organizations.AsNoTracking().OrderBy(x => x.Id).ToList());

    public Organization ReadOrganizationById(int id) =>
        Execute(nameof(ReadOrganizationById), new { id }, () =>
            Context.Organizations.AsNoTracking().SingleOrDefault(x => x.Id == id)
            ?? throw new KeyNotFoundException("Запись справочника не найдена."));

    public void CreateOrganization(Organization organization) =>
        Execute(nameof(CreateOrganization), new { organization.Id, organization.Name, organization.Inn }, () =>
        {
            Context.Organizations.Add(organization);
            var saved = Context.SaveChanges();
            return new { organization.Id, Saved = saved };
        });

    public void UpdateOrganization(Organization organization) =>
        Execute(nameof(UpdateOrganization), new { organization.Id, organization.Name, organization.Inn }, () =>
        {
            var current = Context.Organizations.Find(organization.Id)
                ?? throw new KeyNotFoundException("Запись справочника не найдена.");
            Context.Entry(current).CurrentValues.SetValues(organization);
            return Context.SaveChanges();
        });

    public void DeleteOrganization(int id) =>
        Execute(nameof(DeleteOrganization), new { id }, () =>
        {
            if (Context.Contracts.Any(x => x.OrganizationId == id))
            {
                throw new InvalidOperationException("Запись используется в договорах или отчётах.");
            }

            var current = Context.Organizations.Find(id)
                ?? throw new KeyNotFoundException("Запись справочника не найдена.");
            Context.Organizations.Remove(current);
            return Context.SaveChanges();
        });
}
