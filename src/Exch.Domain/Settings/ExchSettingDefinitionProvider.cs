using Volo.Abp.Settings;

namespace Exch.Settings;

public class ExchSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ExchSettings.MySetting1));
    }
}
