using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Qa
{
    [Dependency(ReplaceServices = true)]
    public class QaBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Qa";
    }
}
