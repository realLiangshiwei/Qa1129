using Qa.Localization;
using Volo.Abp.Application.Services;

namespace Qa
{
    public abstract class QaAppService : ApplicationService
    {
        protected QaAppService()
        {
            LocalizationResource = typeof(QaResource);
            ObjectMapperContext = typeof(QaApplicationModule);
        }
    }
}
