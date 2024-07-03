using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Exch.App.Transfers;

public static class TransferEfCoreQueryableExtensions
{
    public static IQueryable<Transfer> IncludeDetails(this IQueryable<Transfer> queryable, bool include = true)
    {
        if (!include)
        {
            return queryable;
        }

        return queryable
            ;
    }
}
