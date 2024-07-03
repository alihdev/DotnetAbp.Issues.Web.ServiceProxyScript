using System;
using Volo.Abp.Application.Dtos;

namespace Exch.App.Transfers.Dtos;

[Serializable]
public class TransferDto : FullAuditedEntityDto<int>
{
    public string Name { get; set; }

    public string Slug { get; set; }
}