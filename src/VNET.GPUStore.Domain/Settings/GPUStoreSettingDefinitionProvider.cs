using Volo.Abp.Settings;

namespace VNET.GPUStore.Settings;

public class GPUStoreSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(GPUStoreSettings.MySetting1));
    }
}
