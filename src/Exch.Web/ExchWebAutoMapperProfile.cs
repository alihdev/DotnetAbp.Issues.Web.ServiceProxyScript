using Exch.App.Transfers.Dtos;
using Exch.Web.Pages.App.Transfers.Transfer.ViewModels;
using AutoMapper;

namespace Exch.Web;

public class ExchWebAutoMapperProfile : Profile
{
    public ExchWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<TransferDto, EditTransferViewModel>();
        CreateMap<CreateTransferViewModel, TransferCreateDto>();
        CreateMap<EditTransferViewModel, TransferUpdateDto>();
    }
}
