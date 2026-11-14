using ItServiceAccounting.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ItServiceAccounting.Data;

public sealed class DataContext : DbContext
{
    public DbSet<Organization> Organizations => Set<Organization>();
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Service> Services => Set<Service>();
    public DbSet<Contract> Contracts => Set<Contract>();
    public DbSet<ServiceContract> ServiceContracts => Set<ServiceContract>();
    public DbSet<WorkReport> WorkReports => Set<WorkReport>();

    internal static IConfigurationRoot ReadSettings(string directory) =>
        new ConfigurationBuilder().SetBasePath(directory).AddJsonFile("appsettings.json").Build();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var settings = ReadSettings(AppContext.BaseDirectory);
        var connectionString = settings.GetConnectionString("Accounting")
            ?? throw new InvalidOperationException("В appsettings.json отсутствует строка подключения Accounting.");
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contract>(contract =>
        {
            contract.HasOne(x => x.Organization).WithMany().HasForeignKey(x => x.OrganizationId)
                .OnDelete(DeleteBehavior.Restrict);
            contract.HasOne(x => x.Employee).WithMany().HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);
            contract.HasMany(x => x.ServiceContracts).WithOne(x => x.Contract).HasForeignKey(x => x.ContractId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<ServiceContract>().HasOne(x => x.Service).WithMany()
            .HasForeignKey(x => x.ServiceId).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<WorkReport>(report =>
        {
            report.HasOne(x => x.Contract).WithMany().HasForeignKey(x => x.ContractId)
                .OnDelete(DeleteBehavior.Restrict);
            report.HasOne(x => x.Employee).WithMany().HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}
