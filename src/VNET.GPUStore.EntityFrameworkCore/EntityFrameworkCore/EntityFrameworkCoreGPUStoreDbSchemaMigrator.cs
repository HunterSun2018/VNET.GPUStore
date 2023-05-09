using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VNET.GPUStore.Data;
using Volo.Abp.DependencyInjection;

namespace VNET.GPUStore.EntityFrameworkCore;

public class EntityFrameworkCoreGPUStoreDbSchemaMigrator
    : IGPUStoreDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreGPUStoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the GPUStoreDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<GPUStoreDbContext>()
            .Database
            .MigrateAsync();
    }
}
