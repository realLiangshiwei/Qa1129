using Microsoft.Extensions.DependencyInjection;
using Qa.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.WebAssembly.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace Qa.Blazor
{
    [DependsOn(
        typeof(QaHttpApiClientModule),
        typeof(AbpAutoMapperModule)
        )]
    public class QaBlazorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<QaBlazorModule>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<QaBlazorAutoMapperProfile>(validate: true);
            });

            Configure<AbpNavigationOptions>(options =>
            {
                options.MenuContributors.Add(new QaMenuContributor());
            });

            Configure<AbpRouterOptions>(options =>
            {
                options.AdditionalAssemblies.Add(typeof(QaBlazorModule).Assembly);
            });
        }
    }
}