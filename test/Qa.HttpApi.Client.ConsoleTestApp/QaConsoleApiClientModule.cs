using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Qa
{
    [DependsOn(
        typeof(QaHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class QaConsoleApiClientModule : AbpModule
    {
        
    }
}
