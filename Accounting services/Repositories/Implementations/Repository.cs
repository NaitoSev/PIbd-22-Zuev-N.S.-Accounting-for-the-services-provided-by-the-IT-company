using ItServiceAccounting.Data;
using Serilog;

namespace ItServiceAccounting.Repositories.Implementations;

internal abstract class Repository(DataContext context, ILogger logger)
{
    protected DataContext Context { get; } = context;

    protected T Execute<T>(string operation, object input, Func<T> action)
    {
        var log = logger.ForContext("Repository", GetType().Name);
        log.Information("{Operation} started with {@Input}", operation, input);
        try
        {
            var result = action();
            log.Information("{Operation} succeeded with {@Result}", operation, result);
            return result;
        }
        catch (Exception ex)
        {
            log.Error(ex, "{Operation} failed", operation);
            throw;
        }
        finally
        {
            Context.ChangeTracker.Clear();
        }
    }
}
