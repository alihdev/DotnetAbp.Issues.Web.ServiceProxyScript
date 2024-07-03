using Volo.Abp.Modularity;

namespace Exch;

[DependsOn(
    typeof(ExchApplicationModule),
    typeof(ExchDomainTestModule)
)]
public class ExchApplicationTestModule : AbpModule
{

}
