using System.Threading.Tasks;

namespace Exch.Data;

public interface IExchDbSchemaMigrator
{
    Task MigrateAsync();
}
