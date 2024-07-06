using Exch.App.Transfers;
using Exch.App.Transfers.Dtos;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Exch.Controllers.App.Transfers;

public class TransferController(ITransferAppService transferAppService) : ExchController
{
    private readonly ITransferAppService _transferAppService = transferAppService;

    public Task<TransferDto> CreateAsync(TransferCreateDto input)
    {
        return _transferAppService.CreateAsync(input);
    }

    public Task<TransferDto> UpdateAsync(int id, TransferUpdateDto input)
    {
        return _transferAppService.UpdateAsync(id, input);
    }

    public Task<TransferDto> GetAsync(int id)
    {
        return _transferAppService.GetAsync(id);
    }

    public Task<PagedResultDto<TransferDto>> GetListAsync(TransferGetListInput input)
    {
        return _transferAppService.GetListAsync(input);
    }

    public Task DeleteAsync(int id)
    {
        return _transferAppService.DeleteAsync(id);
    }
}
