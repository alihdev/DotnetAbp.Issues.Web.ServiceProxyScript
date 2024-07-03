using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Exch.Web.Pages.App.Transfers.Transfer;

public class IndexModel : ExchPageModel
{
    public TransferFilterInput TransferFilter { get; set; }
    
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}

public class TransferFilterInput
{
    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "TransferName")]
    public string? Name { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "TransferSlug")]
    public string? Slug { get; set; }
}
