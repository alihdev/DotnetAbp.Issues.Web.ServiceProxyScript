using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exch.App.Transfers;
using Exch.App.Transfers.Dtos;
using Exch.Web.Pages.App.Transfers.Transfer.ViewModels;

namespace Exch.Web.Pages.App.Transfers.Transfer;

public class CreateModalModel : ExchPageModel
{
    [BindProperty]
    public CreateTransferViewModel ViewModel { get; set; }

    private readonly ITransferAppService _service;

    public CreateModalModel(ITransferAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateTransferViewModel, TransferCreateDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}