using VNET.GPUStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace VNET.GPUStore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class GPUStoreController : AbpControllerBase
{
    protected GPUStoreController()
    {
        LocalizationResource = typeof(GPUStoreResource);
    }
}
