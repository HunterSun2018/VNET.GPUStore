using Volo.Abp.Modularity;

namespace VNET.GPUStore;

[DependsOn(
    typeof(GPUStoreApplicationModule),
    typeof(GPUStoreDomainTestModule)
    )]
public class GPUStoreApplicationTestModule : AbpModule
{

}
