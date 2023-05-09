using VNET.GPUStore.Localization;
using Volo.Abp.AspNetCore.Components;

namespace VNET.GPUStore.Blazor;

public abstract class GPUStoreComponentBase : AbpComponentBase
{
    protected GPUStoreComponentBase()
    {
        LocalizationResource = typeof(GPUStoreResource);
    }
}
