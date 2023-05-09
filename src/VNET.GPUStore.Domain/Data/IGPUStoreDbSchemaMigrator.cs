using System.Threading.Tasks;

namespace VNET.GPUStore.Data;

public interface IGPUStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
