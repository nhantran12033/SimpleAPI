using Volo.Abp.Settings;

namespace SimpleAPI.Settings;

public class SimpleAPISettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SimpleAPISettings.MySetting1));
    }
}
