using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Exch.Web;

[Dependency(ReplaceServices = true)]
public class ExchBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Exch";
}
