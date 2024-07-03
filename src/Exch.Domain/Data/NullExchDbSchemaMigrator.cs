using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Exch.Data;

/* This is used if database provider does't define
 * IExchDbSchemaMigrator implementation.
 */
public class NullExchDbSchemaMigrator : IExchDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
