using System;
using System.Linq;
using System.Threading.Tasks;
using Exch.Permissions;
using Exch.App.Transfers.Dtos;
using Volo.Abp.Application.Services;

namespace Exch.App.Transfers;


public class TransferAppService : CrudAppService<Transfer, TransferDto, int, TransferGetListInput, TransferCreateDto, TransferUpdateDto>,
    ITransferAppService
{
    protected override string GetPolicyName { get; set; } = ExchPermissions.Transfer.Default;
    protected override string GetListPolicyName { get; set; } = ExchPermissions.Transfer.Default;
    protected override string CreatePolicyName { get; set; } = ExchPermissions.Transfer.Create;
    protected override string UpdatePolicyName { get; set; } = ExchPermissions.Transfer.Update;
    protected override string DeletePolicyName { get; set; } = ExchPermissions.Transfer.Delete;

    private readonly ITransferRepository _repository;

    public TransferAppService(ITransferRepository repository) : base(repository)
    {
        _repository = repository;
    }

    protected override async Task<IQueryable<Transfer>> CreateFilteredQueryAsync(TransferGetListInput input)
    {
        return (await base.CreateFilteredQueryAsync(input))
            .WhereIf(!input.Name.IsNullOrWhiteSpace(), x => x.Name.Contains(input.Name))
            .WhereIf(!input.Slug.IsNullOrWhiteSpace(), x => x.Slug.Contains(input.Slug))
            ;
    }
}
