using Volo.Abp.Modularity;

namespace Exch;

public abstract class ExchApplicationTestBase<TStartupModule> : ExchTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
