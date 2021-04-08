using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Qa.Blazor.Menus
{
    public class QaMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            //Add main menu items.
            context.Menu.AddItem(new ApplicationMenuItem(QaMenus.Prefix, displayName: "Qa", "/Qa", icon: "fa fa-globe"));
            
            return Task.CompletedTask;
        }
    }
}