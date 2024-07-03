using System;
using Exch.App.Transfers.Dtos;
using Volo.Abp.Application.Services;

namespace Exch.App.Transfers;


public interface ITransferAppService :
    ICrudAppService< 
        TransferDto, 
        int, 
        TransferGetListInput,
        TransferCreateDto,
        TransferUpdateDto>
{

}