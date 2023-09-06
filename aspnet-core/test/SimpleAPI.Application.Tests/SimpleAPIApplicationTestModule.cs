using Volo.Abp.Modularity;

namespace SimpleAPI;

[DependsOn(
    typeof(SimpleAPIApplicationModule),
    typeof(SimpleAPIDomainTestModule)
    )]
public class SimpleAPIApplicationTestModule : AbpModule
{

}
