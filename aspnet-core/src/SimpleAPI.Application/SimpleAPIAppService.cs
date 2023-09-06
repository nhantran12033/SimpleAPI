using System;
using System.Collections.Generic;
using System.Text;
using SimpleAPI.Localization;
using Volo.Abp.Application.Services;

namespace SimpleAPI;

/* Inherit your application services from this class.
 */
public abstract class SimpleAPIAppService : ApplicationService
{
    protected SimpleAPIAppService()
    {
        LocalizationResource = typeof(SimpleAPIResource);
    }
}
