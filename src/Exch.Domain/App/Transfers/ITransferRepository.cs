using System;
using Volo.Abp.Domain.Repositories;

namespace Exch.App.Transfers;

public interface ITransferRepository : IRepository<Transfer, int>
{
}
