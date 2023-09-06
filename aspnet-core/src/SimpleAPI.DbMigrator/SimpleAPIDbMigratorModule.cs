using SimpleAPI.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace SimpleAPI.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SimpleAPIEntityFrameworkCoreModule),
    typeof(SimpleAPIApplicationContractsModule)
    )]
public class SimpleAPIDbMigratorModule : AbpModule
{
}
