using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace VNET.GPUStore.Blazor;

[Dependency(ReplaceServices = true)]
public class GPUStoreBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "GPUStore";
}
