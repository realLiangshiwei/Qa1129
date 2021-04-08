using Qa.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Qa
{
    public abstract class QaController : AbpController
    {
        protected QaController()
        {
            LocalizationResource = typeof(QaResource);
        }
    }
}
