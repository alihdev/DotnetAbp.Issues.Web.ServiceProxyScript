using Volo.Abp.Modularity;

namespace Exch;

/* Inherit from this class for your domain layer tests. */
public abstract class ExchDomainTestBase<TStartupModule> : ExchTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
