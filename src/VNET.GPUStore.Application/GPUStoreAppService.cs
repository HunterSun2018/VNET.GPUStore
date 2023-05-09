using System;
using System.Collections.Generic;
using System.Text;
using VNET.GPUStore.Localization;
using Volo.Abp.Application.Services;

namespace VNET.GPUStore;

/* Inherit your application services from this class.
 */
public abstract class GPUStoreAppService : ApplicationService
{
    protected GPUStoreAppService()
    {
        LocalizationResource = typeof(GPUStoreResource);
    }
}
