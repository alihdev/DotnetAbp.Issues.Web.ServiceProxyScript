using Volo.Abp.Modularity;

namespace Exch;

[DependsOn(
    typeof(ExchDomainModule),
    typeof(ExchTestBaseModule)
)]
public class ExchDomainTestModule : AbpModule
{

}
