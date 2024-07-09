using Exch.App.Transfers;
using Exch.App.Transfers.Dtos;

namespace Exch.Web.Controllers.App.Transfers;

public class TransferController(ITransferAppService transferAppService) : AppProController<TransferDto, int, TransferGetListInput, TransferCreateDto, TransferUpdateDto>(transferAppService)
{
}
