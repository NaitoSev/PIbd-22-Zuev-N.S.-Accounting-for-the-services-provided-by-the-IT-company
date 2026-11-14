using ItServiceAccounting.Data;
using ItServiceAccounting.Forms;
using ItServiceAccounting.Repositories;
using ItServiceAccounting.Repositories.Implementations;
using Serilog;
using Unity;
using Unity.Lifetime;

namespace ItServiceAccounting;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        try
        {
            Directory.SetCurrentDirectory(AppContext.BaseDirectory);
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(DataContext.ReadSettings(AppContext.BaseDirectory))
                .CreateLogger();

            using var container = CreateContainer(Log.Logger);
            Application.Run(container.Resolve<FormItCompany>());
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Application failed");
            MessageBox.Show(ex.Message, "Ошибка запуска", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }

    private static IUnityContainer CreateContainer(ILogger logger)
    {
        var container = new UnityContainer();
        container.RegisterInstance(logger, new ExternallyControlledLifetimeManager());
        container.RegisterType<DataContext>(new TransientLifetimeManager());
        container.RegisterType<IOrganizationRepository, OrganizationRepository>();
        container.RegisterType<IEmployeeRepository, EmployeeRepository>();
        container.RegisterType<IServiceRepository, ServiceRepository>();
        container.RegisterType<IContractRepository, ContractRepository>();
        container.RegisterType<IWorkReportRepository, WorkReportRepository>();
        return container;
    }
}
