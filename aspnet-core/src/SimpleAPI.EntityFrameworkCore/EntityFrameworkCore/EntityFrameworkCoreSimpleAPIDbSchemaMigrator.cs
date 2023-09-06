using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SimpleAPI.Data;
using Volo.Abp.DependencyInjection;

namespace SimpleAPI.EntityFrameworkCore;

public class EntityFrameworkCoreSimpleAPIDbSchemaMigrator
    : ISimpleAPIDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSimpleAPIDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SimpleAPIDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SimpleAPIDbContext>()
            .Database
            .MigrateAsync();
    }
}
