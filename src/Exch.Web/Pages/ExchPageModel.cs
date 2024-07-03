using Exch.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Exch.Web.Pages;

public abstract class ExchPageModel : AbpPageModel
{
    protected ExchPageModel()
    {
        LocalizationResourceType = typeof(ExchResource);
    }
}
