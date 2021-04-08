using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Qa
{
    [DependsOn(
        typeof(QaApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class QaHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Qa";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(QaApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
