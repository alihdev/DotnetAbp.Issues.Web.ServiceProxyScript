using System;
using System.Linq;
using System.Threading.Tasks;
using Exch.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Exch.App.Transfers;

public class TransferRepository : EfCoreRepository<ExchDbContext, Transfer, int>, ITransferRepository
{
    public TransferRepository(IDbContextProvider<ExchDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Transfer>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}