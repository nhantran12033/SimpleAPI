using SimpleAPI.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SimpleAPI;

[DependsOn(
    typeof(SimpleAPIEntityFrameworkCoreTestModule)
    )]
public class SimpleAPIDomainTestModule : AbpModule
{

}
