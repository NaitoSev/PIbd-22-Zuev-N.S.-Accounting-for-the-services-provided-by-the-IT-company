using Microsoft.EntityFrameworkCore.Design;

namespace ItServiceAccounting.Data;

public sealed class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args) => new();
}
