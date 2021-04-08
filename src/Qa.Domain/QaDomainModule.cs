using Volo.Abp.Domain;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Qa
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(QaDomainSharedModule),
        typeof(AbpIdentityDomainModule)
    )]
    public class QaDomainModule : AbpModule
    {

    }
}
