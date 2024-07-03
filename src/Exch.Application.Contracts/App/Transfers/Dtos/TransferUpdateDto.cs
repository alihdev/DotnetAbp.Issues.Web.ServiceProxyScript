using System;

namespace Exch.App.Transfers.Dtos;

[Serializable]
public class TransferUpdateDto
{
    public string Name { get; set; }

    public string Slug { get; set; }
}