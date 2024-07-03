using Exch.App.Transfers;
using Exch.App.Transfers.Dtos;
using AutoMapper;

namespace Exch;

public class ExchApplicationAutoMapperProfile : Profile
{
    public ExchApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Transfer, TransferDto>();
        CreateMap<TransferCreateDto, Transfer>(MemberList.Source);
        CreateMap<TransferUpdateDto, Transfer>(MemberList.Source);
    }
}
