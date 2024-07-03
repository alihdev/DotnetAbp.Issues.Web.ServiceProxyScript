using System;
using System.Collections.Generic;
using System.Text;
using Exch.Localization;
using Volo.Abp.Application.Services;

namespace Exch;

/* Inherit your application services from this class.
 */
public abstract class ExchAppService : ApplicationService
{
    protected ExchAppService()
    {
        LocalizationResource = typeof(ExchResource);
    }
}
