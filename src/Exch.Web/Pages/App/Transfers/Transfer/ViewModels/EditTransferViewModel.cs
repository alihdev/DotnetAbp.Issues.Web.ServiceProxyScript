using System;
using System.ComponentModel.DataAnnotations;

namespace Exch.Web.Pages.App.Transfers.Transfer.ViewModels;

public class EditTransferViewModel
{
    [Display(Name = "TransferName")]
    public string Name { get; set; }

    [Display(Name = "TransferSlug")]
    public string Slug { get; set; }
}
