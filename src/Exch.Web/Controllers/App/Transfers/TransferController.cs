using Exch.App.Transfers;
using Exch.App.Transfers.Dtos;
using Exch.Web.Controllers.App;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Exch.Web.Controllers.App.Transfers;

public class TransferController(ITransferAppService transferAppService) : AppController
{
    private readonly ITransferAppService _transferAppService = transferAppService;

    [HttpPost]
    public Task<TransferDto> CreateAsync(TransferCreateDto input)
    {
        return _transferAppService.CreateAsync(input);
    }

    [HttpPut("{id}")]
    public Task<TransferDto> UpdateAsync(int id, TransferUpdateDto input)
    {
        return _transferAppService.UpdateAsync(id, input);
    }

    [HttpGet("{id}")]
    public Task<TransferDto> GetAsync(int id)
    {
        return _transferAppService.GetAsync(id);
    }

    [HttpGet]
    public Task<PagedResultDto<TransferDto>> GetListAsync(TransferGetListInput input)
    {
        return _transferAppService.GetListAsync(input);
    }

    [HttpDelete("{id}")]
    public Task DeleteAsync(int id)
    {
        return _transferAppService.DeleteAsync(id);
    }
}
