using Localization.Resources.AbpUi;
using Qa.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Qa
{
    [DependsOn(
        typeof(QaApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class QaHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(QaHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<QaResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
