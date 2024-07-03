using Volo.Abp.Domain.Entities.Auditing;

namespace Exch.App.Transfers;

public class Transfer : FullAuditedAggregateRoot<int>
{
    public string Name { get; set; }
    public string Slug { get; set; }

    protected Transfer()
    {
    }

    public Transfer(
        int id,
        string name,
        string slug
    ) : base(id)
    {
        Name = name;
        Slug = slug;
    }
}
