using Asp.Versioning;
using Exch.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Exch.Web.Controllers.App;

[Controller]
[RemoteService(Name = "Exch")]
[Area("Exch")]
[ControllerName("Exch")]
[Route("api/app/[controller]")]
public class AppProController<TDto, TKey, TGetListInput, TCreateInput, TUpdateInput> : ExchController
{
    protected readonly ICrudAppService<TDto, TKey, TGetListInput, TCreateInput, TUpdateInput> appService;

    public AppProController(ICrudAppService<TDto, TKey, TGetListInput, TCreateInput, TUpdateInput> appService)
    {
        this.appService = appService;
    }

    [HttpPost]
    public Task<TDto> CreateAsync(TCreateInput input)
    {
        return appService.CreateAsync(input);
    }

    [HttpPut("{id}")]
    public Task<TDto> UpdateAsync(TKey id, TUpdateInput input)
    {
        return appService.UpdateAsync(id, input);
    }

    [HttpGet("{id}")]
    public Task<TDto> GetAsync(TKey id)
    {
        return appService.GetAsync(id);
    }

    [HttpGet]
    public Task<PagedResultDto<TDto>> GetListAsync(TGetListInput input)
    {
        return appService.GetListAsync(input);
    }

    [HttpDelete("{id}")]
    public Task DeleteAsync(TKey id)
    {
        return appService.DeleteAsync(id);
    }
}
