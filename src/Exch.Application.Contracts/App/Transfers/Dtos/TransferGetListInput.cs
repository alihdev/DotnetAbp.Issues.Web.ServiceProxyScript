using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace Exch.App.Transfers.Dtos;

[Serializable]
public class TransferGetListInput : PagedAndSortedResultRequestDto
{
    public string? Name { get; set; }

    public string? Slug { get; set; }
}