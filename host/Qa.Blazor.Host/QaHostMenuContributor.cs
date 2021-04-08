using System.Threading.Tasks;
using Qa.Localization;
using Volo.Abp.UI.Navigation;

namespace Qa.Blazor.Host
{
    public class QaHostMenuContributor : IMenuContributor
    {
        public Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if(context.Menu.DisplayName != StandardMenus.Main)
            {
                return Task.CompletedTask;
            }

            var l = context.GetLocalizer<QaResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    "Qa.Home",
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home"
                )
            );

            return Task.CompletedTask;
        }
    }
}
