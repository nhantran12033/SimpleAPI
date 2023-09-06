using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SimpleAPI;

[Dependency(ReplaceServices = true)]
public class SimpleAPIBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SimpleAPI";
}
