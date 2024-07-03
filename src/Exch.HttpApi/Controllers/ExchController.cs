using Exch.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Exch.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ExchController : AbpControllerBase
{
    protected ExchController()
    {
        LocalizationResource = typeof(ExchResource);
    }
}
