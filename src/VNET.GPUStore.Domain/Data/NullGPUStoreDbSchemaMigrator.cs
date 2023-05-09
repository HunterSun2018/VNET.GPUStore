using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace VNET.GPUStore.Data;

/* This is used if database provider does't define
 * IGPUStoreDbSchemaMigrator implementation.
 */
public class NullGPUStoreDbSchemaMigrator : IGPUStoreDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
