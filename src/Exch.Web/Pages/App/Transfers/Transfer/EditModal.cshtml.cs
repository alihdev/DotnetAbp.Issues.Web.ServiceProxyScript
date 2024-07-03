using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exch.App.Transfers;
using Exch.App.Transfers.Dtos;
using Exch.Web.Pages.App.Transfers.Transfer.ViewModels;

namespace Exch.Web.Pages.App.Transfers.Transfer;

public class EditModalModel : ExchPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public int Id { get; set; }

    [BindProperty]
    public EditTransferViewModel ViewModel { get; set; }

    private readonly ITransferAppService _service;

    public EditModalModel(ITransferAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<TransferDto, EditTransferViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<EditTransferViewModel, TransferUpdateDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}