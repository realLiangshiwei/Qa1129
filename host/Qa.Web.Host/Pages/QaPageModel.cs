using Qa.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Qa.Pages
{
    public abstract class QaPageModel : AbpPageModel
    {
        protected QaPageModel()
        {
            LocalizationResourceType = typeof(QaResource);
        }
    }
}