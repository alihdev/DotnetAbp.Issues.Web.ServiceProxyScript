using System;

namespace Exch.App.Transfers.Dtos;

[Serializable]
public class TransferCreateDto
{
    public string Name { get; set; }

    public string Slug { get; set; }
}