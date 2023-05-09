using VNET.GPUStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace VNET.GPUStore;

[DependsOn(
    typeof(GPUStoreEntityFrameworkCoreTestModule)
    )]
public class GPUStoreDomainTestModule : AbpModule
{

}
