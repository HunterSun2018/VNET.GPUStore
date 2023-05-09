using VNET.GPUStore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace VNET.GPUStore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(GPUStoreEntityFrameworkCoreModule),
    typeof(GPUStoreApplicationContractsModule)
    )]
public class GPUStoreDbMigratorModule : AbpModule
{

}
