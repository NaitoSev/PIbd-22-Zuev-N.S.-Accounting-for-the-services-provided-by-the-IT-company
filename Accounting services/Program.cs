using ItServiceAccounting.Forms;
using ItServiceAccounting.Repositories;
using ItServiceAccounting.Repositories.Implementations;
using Unity;
using Unity.Lifetime;

namespace ItServiceAccounting;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(CreateContainer().Resolve<FormItCompany>());
    }

    private static IUnityContainer CreateContainer()
    {
        var container = new UnityContainer();

        container.RegisterType<IOrganizationRepository, OrganizationRepository>(new TransientLifetimeManager());
        container.RegisterType<IEmployeeRepository, EmployeeRepository>(new TransientLifetimeManager());
        container.RegisterType<IServiceRepository, ServiceRepository>(new TransientLifetimeManager());
        container.RegisterType<IContractRepository, ContractRepository>(new TransientLifetimeManager());
        container.RegisterType<IWorkReportRepository, WorkReportRepository>(new TransientLifetimeManager());

        return container;
    }
}
