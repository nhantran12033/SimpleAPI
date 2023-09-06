using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SimpleAPI.Data;

/* This is used if database provider does't define
 * ISimpleAPIDbSchemaMigrator implementation.
 */
public class NullSimpleAPIDbSchemaMigrator : ISimpleAPIDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
