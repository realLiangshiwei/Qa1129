using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Qa
{
    [DependsOn(
        typeof(QaDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class QaApplicationContractsModule : AbpModule
    {

    }
}
