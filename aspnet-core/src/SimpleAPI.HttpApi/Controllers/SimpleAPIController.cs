using SimpleAPI.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SimpleAPIController : AbpControllerBase
{
    protected SimpleAPIController()
    {
        LocalizationResource = typeof(SimpleAPIResource);
    }
}
